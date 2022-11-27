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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            lblKulAd.Text = UserInfo.kulAd;
            lblKulYetki.Text = UserInfo.yetki;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }

        private void btnSistemBaslat_Click(object sender, EventArgs e)
        {
            GirisCikisIslemler girisCikisIslemler = new GirisCikisIslemler();
            girisCikisIslemler.Show();
        }

        private void btnPersonelYonetim_Click(object sender, EventArgs e)
        {
            if (UserInfo.yetki.Contains("Admin") || UserInfo.yetki.Contains("Yonetici") || UserInfo.yetki.Contains("IK"))
            {
                PersonelYonetim personelYonetim = new PersonelYonetim();
                personelYonetim.Show();
            }
            else
                MessageBox.Show("Yetkin Yok Kardeş!");
        }

        private void btnIzinYonetim_Click(object sender, EventArgs e)
        {
            if (UserInfo.yetki.Contains("Admin")|| UserInfo.yetki.Contains("Yonetici"))
            {
                IzinYonetim izinYonetim = new IzinYonetim();
                izinYonetim.Show();
            }
            else
                MessageBox.Show("Yetkin Yok Kardeş!");
        }

        private void btnKullaniciYonetim_Click(object sender, EventArgs e)
        {
            if (UserInfo.yetki.Contains("Admin"))
            {
                KullaniciYonetim kullaniciYonetim = new KullaniciYonetim();
                kullaniciYonetim.Show();
            }
            else
                MessageBox.Show("Yetkin Yok Kardeş!");

        }

        private void btnDepartmanYonetim_Click(object sender, EventArgs e)
        {
            if (UserInfo.yetki.Contains("Admin"))
            {
                DepartmanYonetim departmanYonetim = new DepartmanYonetim();
                departmanYonetim.Show();
            }
            else
                MessageBox.Show("Yetkin Yok Kardeş!");
        }

    }
}

