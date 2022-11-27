using BusinessLayer.Concrete;
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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        KullaniciManager kullaniciManager = new KullaniciManager();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = kullaniciManager.Get(x=>x.KullaniciAd==txtKulAd.Text&&x.KullaniciSifre==txtSifre.Text);
            if (kullanici!=null)
            {
                UserInfo.kulAd = kullanici.KullaniciAd;
                UserInfo.yetki = kullanici.Yetkis.YetkiAd;
                Anasayfa anasayfaFrm = new Anasayfa();
                anasayfaFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Bilgileri Hatalı!");
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
         
        }
    }
}
