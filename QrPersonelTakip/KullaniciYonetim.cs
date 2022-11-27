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
    public partial class KullaniciYonetim : Form
    {
        public KullaniciYonetim()
        {
            InitializeComponent();
        }
        YetkiManager yetkiManager = new YetkiManager();
        KullaniciManager kullaniciManager = new KullaniciManager();
        KullaniciManager kullaniciManager2 = new KullaniciManager();
        PersonelManager personelManager = new PersonelManager();
        List<Personels> personeller;
        private void KullaniciYonetim_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var yetkiler = yetkiManager.GetAll().Select(x => new { x.YetkiID, x.YetkiAd }).ToList();
            var kullanicilar = kullaniciManager2.GetAll().Select(x => new { x.KullaniciID, x.KullaniciAd, x.KullaniciSifre, AdSoyad = x.Personels.PersonelAd + " " + x.Personels.PersonelSoyad, x.Yetkis.YetkiAd }).ToList();
            personeller = personelManager.GetAll();
            dataGridViewYetkiler.DataSource = yetkiler;
            dataGridViewKullanicilar.DataSource = kullanicilar;
            cmbYetkiler.ValueMember = "YetkiID";
            cmbYetkiler.DisplayMember = "YetkiAd";
            cmbYetkiler.DataSource = yetkiler;

        }
        void YetkiEkle()
        {
            IslemKontrol(yetkiManager.Add(txtYetkiAd.Text));
        }
        void YetkiGuncelle()
        {
            IslemKontrol(yetkiManager.Update(txtYetkiId.Text, txtYetkiAd.Text));
        }
        void YetkiSil()
        {
            IslemKontrol(yetkiManager.Delete(txtYetkiId.Text));
        }
        void KullaniciEkle()
        {
            int personelID = Convert.ToInt32(cmbPersoneller.SelectedValue);
            int yetkiId = Convert.ToInt32(cmbYetkiler.SelectedValue);
            IslemKontrol(kullaniciManager.Add(txtKullaniciAd.Text, txtKullaniciSifre.Text, personelID, yetkiId));
        }
        void KullaniciGuncelle()
        {
            int personelID = Convert.ToInt32(cmbPersoneller.SelectedValue);
            int yetkiId = Convert.ToInt32(cmbYetkiler.SelectedValue);
            IslemKontrol(kullaniciManager.Update(txtKullaniciId.Text, txtKullaniciAd.Text, txtKullaniciSifre.Text, personelID, yetkiId));
        }
        void KullaniciSil()
        {
            IslemKontrol(kullaniciManager.Delete(txtKullaniciId.Text));
        }
        void PersonelAra()
        {
            var bulPersonel = personeller.Where(x => x.PersonelAd.Contains(txtPersonelAra.Text) || x.PersonelSoyad.Contains(txtPersonelAra.Text)).Select(x => new { Value = x.PersonelID, Display = x.PersonelAd + " " + x.PersonelSoyad }).ToList();
            cmbPersoneller.ValueMember = "Value";
            cmbPersoneller.DisplayMember = "Display";
            cmbPersoneller.DataSource = bulPersonel;
        }
        void IslemKontrol(bool islem)
        {
            if (islem)
            {
                Listele();
                MessageBox.Show("Islem Başarılı!");
                txtYetkiId.Text = "";
                txtYetkiAd.Text = "";
                txtKullaniciId.Text = "";
                txtKullaniciAd.Text = "";
                txtKullaniciSifre.Text = "";
                txtPersonelAra.Text = "";
            }
            else
            {
                MessageBox.Show("Islem Başarısız!");
            }
        }
        void Temizle(string x)
        {
            if (x == "Y")
            {
                txtYetkiId.Text = "";
                txtYetkiAd.Text = "";
            }
            else
            {
                txtKullaniciId.Text = "";
                txtKullaniciAd.Text = "";
                txtKullaniciSifre.Text = "";
                txtPersonelAra.Text = "";
            }
        }

        private void txtPersonelAra_TextChanged(object sender, EventArgs e)
        {
            PersonelAra();
        }

        private void dataGridViewYetkiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var satir = dataGridViewYetkiler.CurrentRow.Cells;
            txtYetkiId.Text = satir[0].Value.ToString();
            txtYetkiAd.Text = satir[1].Value.ToString();
        }

        private void dataGridViewKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var satir = dataGridViewKullanicilar.CurrentRow.Cells;
            txtKullaniciId.Text = satir[0].Value.ToString();
            txtKullaniciAd.Text = satir[1].Value.ToString();
            txtKullaniciSifre.Text = satir[2].Value.ToString();
            cmbPersoneller.Text = satir[3].Value.ToString();
            cmbYetkiler.Text = satir[4].Value.ToString();
        }

        private void btnYetkiEkle_Click(object sender, EventArgs e)
        {
            YetkiEkle();
        }

        private void btnYetkiGuncelle_Click(object sender, EventArgs e)
        {
            YetkiGuncelle();
        }

        private void btnYetkiSil_Click(object sender, EventArgs e)
        {
            YetkiSil();
        }

        private void btnYetkiTemizle_Click(object sender, EventArgs e)
        {
            Temizle("Y");
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle();
        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            KullaniciSil();
        }

        private void btnKullaniciTemizle_Click(object sender, EventArgs e)
        {
            Temizle("K");
        }
    }
}
