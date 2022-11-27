using AForge.Video;
using AForge.Video.DirectShow;
using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QrPersonelTakip
{
    public partial class GirisCikisIslemler : Form
    {
        public GirisCikisIslemler()
        {
            InitializeComponent();
        }
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;
        IslemManager IslemManager = new IslemManager();
        PersonelManager personelManager = new PersonelManager();
        int sayac = 0;
        private void GirisCikisIslemler_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in fico)
            {
                cmbKameralar.Items.Add(item.Name);
            }
            cmbKameralar.SelectedIndex = 0;
            Listele();
        }
        void Listele()
        {

            var islemler = IslemManager.GetAll().Select(x => new { x.Personels.PersonelAd, x.Personels.PersonelSoyad, x.IslemTarih, Islem = x.IslemAd ? "Giris" : "Cikis" }).ToList();
            dataGridViewIslem.DataSource = islemler;
        }

        void KameraAcKapa(bool islem)
        {
            if (islem)
            {
                vcd = new VideoCaptureDevice(fico[cmbKameralar.SelectedIndex].MonikerString);
                vcd.NewFrame += Vcd_NewFrame;
                vcd.Start();
                btnKamera.Text = "Durdur";
                timer1.Start();
                lblDurum.Text = "Aktif";
                lblDurum.ForeColor = Color.Green;
            }
            else
            {
                if (vcd != null)
                {
                    lblDurum.Text = "Pasif";
                    lblDurum.ForeColor = Color.Red;
                    btnKamera.Text = "Başla";
                    vcd.SignalToStop();
                    vcd.NewFrame -= Vcd_NewFrame;
                    vcd = null;
                    timer1.Stop();
                }

            }
        }
        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxKamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxKamera.Image != null)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pictureBoxKamera.Image);
                if (sonuc != null)
                {
                    timer1.Stop();
                    Ekle(sonuc.ToString());
                }
            }
        }
        void Ekle(string qr)
        {
            timer2.Start();
            lblDurum.Text = "İşleniyor...";
            lblDurum.ForeColor = Color.Red;
            var personel = personelManager.Get(x => x.PersonelQR == qr);
            if (personel != null)
            {
                txtPersonelAd.Text = personel.PersonelAd;
                txtPersonelSoyad.Text = personel.PersonelSoyad;
                txtPersonelTc.Text = personel.PersonelTC;
                txtPersonelMeslek.Text = personel.Mesleks.MeslekAd;
                txtPersonelDepartman.Text = personel.Mesleks.Departmen.DepartmanAd;
                pictureBoxResim.ImageLocation = personel.PersonelResim;
                var islemAd = IslemManager.IslemKontrol(personel.PersonelID);
                IslemManager.Add(islemAd,personel.PersonelID);
                Listele();
            }
            
           

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac>2) 
            {
                lblDurum.Text = "Aktif";
                lblDurum.ForeColor = Color.Green;
                timer1.Start();
                timer2.Stop();
                sayac = 0;
            }
            
        }

        private void GirisCikisIslemler_FormClosed(object sender, FormClosedEventArgs e)
        {
            KameraAcKapa(false);
        }

        private void btnKamera_Click(object sender, EventArgs e)
        {
            if (btnKamera.Text == "Başla")
                KameraAcKapa(true);
            else
                KameraAcKapa(false);
        }

        
    }
}
