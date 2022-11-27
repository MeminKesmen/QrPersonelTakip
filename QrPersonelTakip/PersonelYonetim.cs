using AForge.Video;
using AForge.Video.DirectShow;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrPersonelTakip
{
    public partial class PersonelYonetim : Form
    {
        public PersonelYonetim()
        {
            InitializeComponent();
        }
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;

        PersonelManager personelManager = new PersonelManager();
        MeslekManager meslekManager = new MeslekManager();
        List<Personels> personeller;
        Guid qr;
        string dosyaYol = "";
        private void PersonelYonetim_Load(object sender, EventArgs e)
        {
            dosyaYol = YolBul();
            Temizle();
            Listele();
            KameraListele();
        }
        void IslemKontrol(bool islem)
        {
            if (islem)
            {
                Listele();
                MessageBox.Show("Islem Başarılı!");
                Temizle();
            }
            else
            {
                MessageBox.Show("Islem Başarısız!");
            }
        }
        void Listele()
        {
            personeller = personelManager.GetAll();
            var meslekler = meslekManager.GetAll().Select(x => new { x.MeslekID, x.MeslekAd }).ToList();
            cmbMeslekler.ValueMember = "MeslekID";
            cmbMeslekler.DisplayMember = "MeslekAd";
            cmbMeslekler.DataSource = meslekler;
            Ara();
        }
        void Ara(string filter = "")
        {

            var personelView = personeller.Where(x => x.PersonelAd.Contains(filter) || x.PersonelSoyad.Contains(filter)).Select(x => new { x.PersonelID, x.PersonelAd, x.PersonelSoyad, x.PersonelTC, x.PersonelTel, x.PersonelMail }).ToList();
            dataGridViewPersoneller.DataSource = personelView;
        }
        void Ekle()
        {

            int meslekId = Convert.ToInt32(cmbMeslekler.SelectedValue);
            qr = Guid.NewGuid();
            IslemKontrol(personelManager.Add(txtPersonelAd.Text, txtPersonelSoyad.Text, txtPersonelTc.Text, txtPersonelTel.Text, txtPersonelAdres.Text, txtPersonelMaas.Text, txtPersonelDTarih.Text, txtPersonelMail.Text, qr.ToString(), pictureBoxResim.ImageLocation, meslekId));

        }
        void Guncelle()
        {
            int meslekId = Convert.ToInt32(cmbMeslekler.SelectedValue);
            IslemKontrol(personelManager.Update(txtPersonelId.Text, txtPersonelAd.Text, txtPersonelSoyad.Text, txtPersonelTc.Text, txtPersonelTel.Text, txtPersonelAdres.Text, txtPersonelMaas.Text, txtPersonelDTarih.Text, txtPersonelMail.Text, qr.ToString(), pictureBoxResim.ImageLocation, meslekId));

        }
        void Sil()
        {

            IslemKontrol(personelManager.Delete(txtPersonelId.Text));
        }
        void KameraListele()
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in fico)
            {
                cmbKameralar.Items.Add(item.Name);
            }
            cmbKameralar.SelectedIndex = 0;
        }
        void Temizle()
        {
            txtPersonelId.Text = "";
            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";
            txtPersonelTc.Text = "";
            txtPersonelTel.Text = "";
            txtPersonelAdres.Text = "";
            txtPersonelMaas.Text = "";
            txtPersonelDTarih.Text = "";
            txtPersonelMail.Text = "";
            pictureBoxResim.ImageLocation = dosyaYol + "\\EmptyUser.png";

        }
        void KameraAcKapa(bool islem)
        {
            if (islem)
            {
                vcd = new VideoCaptureDevice(fico[cmbKameralar.SelectedIndex].MonikerString);
                vcd.NewFrame += Vcd_NewFrame;
                vcd.Start();
                btnKamera.Text = "Kamera Kapat";
            }
            else
            {
                btnKamera.Text = "Kamera Aç";
                vcd.SignalToStop();
                vcd.NewFrame -= Vcd_NewFrame;
                vcd = null;
                pictureBoxResim.ImageLocation = dosyaYol + "\\EmptyUser.png";
            }
        }
        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxResim.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        string YolBul()
        {
            string yol = "";
            var yolDizi = Environment.CurrentDirectory.Split('\\').ToList();
            foreach (var item in yolDizi)
            {
                if (item == "QrPersonelTakip")
                {
                    yol += item;
                    break;
                }
                yol += item + "\\";
            }

            return yol + "\\PersonelResim\\";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnQrYenile_Click(object sender, EventArgs e)
        {
            qr = Guid.NewGuid();
            IslemKontrol(personelManager.QrYenile(txtPersonelId.Text, qr.ToString()));
        }

        private void txtPersonelAra_TextChanged(object sender, EventArgs e)
        {
            Ara(txtPersonelAra.Text);
        }

        private void btnKamera_Click(object sender, EventArgs e)
        {
            if (btnKamera.Text.Contains("Aç"))
                KameraAcKapa(true);
            else
                KameraAcKapa(false);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (txtPersonelTc.Text.Length == 11 && vcd != null)
            {
                DialogResult dialogResult = MessageBox.Show("Ekrandaki resim kaydedilecek!(Resimler TC bilgilerine göre kaydedilir!)");
                if (dialogResult == DialogResult.OK)
                {
                    pictureBoxResim.Image.Save(dosyaYol + txtPersonelTc.Text + ".png");
                    KameraAcKapa(false);
                    pictureBoxResim.ImageLocation = dosyaYol + txtPersonelTc.Text + ".png";
                }
            }
            else
            {
                MessageBox.Show("TC alanlanı doldurulmadan resim ekleme yapılamaz!");
            }
        }

        private void dataGridViewPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int personelId = Convert.ToInt32(dataGridViewPersoneller.CurrentRow.Cells[0].Value);
            var personel = personelManager.Get(x => x.PersonelID == personelId);
            txtPersonelId.Text = personel.PersonelID.ToString();
            txtPersonelAd.Text = personel.PersonelAd;
            txtPersonelSoyad.Text = personel.PersonelSoyad;
            txtPersonelTc.Text = personel.PersonelTC;
            txtPersonelTel.Text = personel.PersonelTel;
            txtPersonelAdres.Text = personel.PersonelAdres;
            txtPersonelMaas.Text = personel.PersonelMaas.ToString();
            txtPersonelDTarih.Text = personel.PersonelDogumTarih.ToString("dd.MM.yyyy");
            txtPersonelMail.Text = personel.PersonelMail;
            pictureBoxResim.ImageLocation = personel.PersonelResim;
        }
    }
}
