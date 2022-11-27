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
    public partial class IzinYonetim : Form
    {
        public IzinYonetim()
        {
            InitializeComponent();
        }
        IzinManager izinManager = new IzinManager();
        PersonelManager personelManager = new PersonelManager();
        
        List<Izins> izinler;
        List<Personels> personeller;
        

        private void IzinYonetim_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void dataGridViewIzinler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var satir = dataGridViewIzinler.CurrentRow.Cells;
            txtIzınId.Text = satir[0].Value.ToString();
            int pId = Convert.ToInt32(satir[1].Value);
            txtPIzınBaslangic.Text = satir[5].Value.ToString();
            txtPIzinBitis.Text = satir[6].Value.ToString();
            PersonelGetir(pId);
        }
        void Listele()
        {
            izinler = izinManager.GetAll();
            personeller = personelManager.GetAll();
            PersonelIzinAra();
            PersonelAra();
        }
        void PersonelIzinAra()
        {
            var bulIzinler = izinler.Where(x => x.Personels.PersonelAd.Contains(txtIzinPersonelAra.Text) || x.Personels.PersonelSoyad.Contains(txtIzinPersonelAra.Text)).Select(x => new { x.IzinID, x.Personels.PersonelID, x.Personels.PersonelAd, x.Personels.PersonelSoyad, x.Personels.PersonelTC, x.IzinBaslangic, x.IzinBitis }).ToList();
            dataGridViewIzinler.DataSource = bulIzinler;
        }
        void PersonelAra()
        {
            var bulPersoneller = personeller.Where(x => x.PersonelAd.Contains(txtPersonelAra.Text) || x.PersonelSoyad.Contains(txtPersonelAra.Text)).Select(x => new { Value = x.PersonelID, Display = x.PersonelAd + " " + x.PersonelSoyad }).ToList();
            cmbPersoneller.ValueMember = "Value";
            cmbPersoneller.DisplayMember = "Display";
            cmbPersoneller.DataSource = bulPersoneller;
        }
        void IzinEkle()
        {
            if (int.TryParse(txtPersonelId.Text, out int id))
            {
                
                IslemKontrol(izinManager.Add(txtIzınBaslangic.Text, txtIzınBitis.Text, id));
            }
            else
            {
                MessageBox.Show("Personel Seçiniz!");
            }

        }
        void IzinSil()
        {
            IslemKontrol(izinManager.Delete(txtIzınId.Text));
        }
        void Temizle()
        {
            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";
            txtPersonelTc.Text = "";
            txtPersonelMeslek.Text = "";
            pictureBoxResim.ImageLocation = null;
            txtIzınId.Text = "";
            txtIzınBaslangic.Text = "";
            txtIzınBitis.Text = "";
            txtIzinGunToplam.Text = "";
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
        void PersonelGetir(int id)
        {
            txtPersonelId.Text = id.ToString();
            var personel = personelManager.Get(x => x.PersonelID == id);
            txtPersonelAd.Text = personel.PersonelAd;
            txtPersonelSoyad.Text = personel.PersonelSoyad;
            txtPersonelTc.Text = personel.PersonelTC;
            txtPersonelMeslek.Text = personel.Mesleks.MeslekAd;
            pictureBoxResim.ImageLocation = personel.PersonelResim;
            var izinGunToplam = izinler.Where(x => x.Personels.PersonelID == id).Sum(x => (x.IzinBitis - x.IzinBaslangic).Days);
            txtIzinGunToplam.Text = izinGunToplam.ToString();

        }

        private void txtPersonelAra_TextChanged(object sender, EventArgs e)
        {
            PersonelAra();
        }

        private void cmbPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pId = Convert.ToInt32(cmbPersoneller.SelectedValue);
            txtIzınId.Text = "";
            txtIzınBaslangic.Text = "";
            txtIzınBitis.Text = "";
            PersonelGetir(pId);
        }

        private void txtIzinPersonelAra_TextChanged(object sender, EventArgs e)
        {
            PersonelIzinAra();
        }

        private void btnIzinOnay_Click(object sender, EventArgs e)
        {
            IzinEkle();
        }

        private void btnIzinSil_Click(object sender, EventArgs e)
        {
            IzinSil();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
