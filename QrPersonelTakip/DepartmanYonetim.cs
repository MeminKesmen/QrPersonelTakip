using BusinessLayer.Concrete;
using DataAccessLayer;
using EntityLayer.Concrete;
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

namespace QrPersonelTakip
{
    public partial class DepartmanYonetim : Form
    {
        public DepartmanYonetim()
        {
            InitializeComponent();
        }
        DepartmanManager departmanManager = new DepartmanManager();
        MeslekManager meslekManager = new MeslekManager();
        MeslekManager meslekManager2 = new MeslekManager();
    
        private void DepartmanYonetim_Load(object sender, EventArgs e)
        {
            Listele();
           
        }

        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            DeparmtanEkle();
        }

        private void btnDepartmanGuncelle_Click(object sender, EventArgs e)
        {
            DepartmanGuncelle();
        }

        private void btnDepartmanSil_Click(object sender, EventArgs e)
        {
            DepartmanSil();
        }

        private void btnMeslekEkle_Click(object sender, EventArgs e)
        {
            MeslekEkle();
        }

        private void btnMeslekGuncelle_Click(object sender, EventArgs e)
        {
            MeslekGuncelle();
        }

        private void btnMeslekSil_Click(object sender, EventArgs e)
        {
            MeslekSil();
        }
        void Listele()
        {
            
            var departmanlar = departmanManager.GetAll().Select(x => new { x.DepartmanID, x.DepartmanAd }).ToList();
            /*var meslekler = meslekManager.GetAll();*//*.Select(x => new { x.MeslekID, x.MeslekAd, x.Departmen.DepartmanAd }).ToList();*/
            var meslekler = meslekManager2.GetAll().Select(x => new { x.MeslekID, x.MeslekAd, x.Departmen.DepartmanAd }).ToList();
            dataGridViewMeslek.DataSource = meslekler;
            dataGridViewDepartman.DataSource = departmanlar;

           
            cmbDepartmanlar.ValueMember = "DepartmanID";
            cmbDepartmanlar.DisplayMember = "DepartmanAd";
            cmbDepartmanlar.DataSource = departmanlar;
        }
        void DeparmtanEkle()
        {
            IslemKontrol(departmanManager.Add(txtDepartmanAd.Text));
        }
        void DepartmanSil()
        {
            IslemKontrol(departmanManager.Delete(txtDepartmanId.Text));
        }
        void DepartmanGuncelle()
        {
            IslemKontrol(departmanManager.Update(txtDepartmanId.Text, txtDepartmanAd.Text));
        }
        void MeslekEkle()
        {
            int departmanId = Convert.ToInt32(cmbDepartmanlar.SelectedValue);
        
            IslemKontrol(meslekManager.Add(txtMeslekAd.Text, departmanId));
        }
        void MeslekSil()
        {

            IslemKontrol(meslekManager.Delete(txtMeslekId.Text));
        }
        void MeslekGuncelle()

        {
            int departmanId = Convert.ToInt32(cmbDepartmanlar.SelectedValue);
            IslemKontrol(meslekManager.Update(txtMeslekId.Text, txtMeslekAd.Text, departmanId));
        }

        void IslemKontrol(bool islem)
        {
            if (islem)
            {
                Listele();
                MessageBox.Show("Islem Başarılı!");
                txtDepartmanAd.Text = "";
                txtDepartmanId.Text = "";
                txtMeslekAd.Text = "";
                txtMeslekId.Text = "";
            }
            else
            {
                MessageBox.Show("Islem Başarısız!");
            }
        }

        private void dataGridViewDepartman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var seciliSatir = dataGridViewDepartman.CurrentRow;
            txtDepartmanId.Text = seciliSatir.Cells[0].Value.ToString();
            txtDepartmanAd.Text = seciliSatir.Cells[1].Value.ToString();
        }

        private void dataGridViewMeslek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var seciliSatir = dataGridViewMeslek.CurrentRow;
            txtMeslekId.Text = seciliSatir.Cells[0].Value.ToString();
            txtMeslekAd.Text = seciliSatir.Cells[1].Value.ToString();
            var s = seciliSatir.Cells.Count;
            cmbDepartmanlar.Text = seciliSatir.Cells[2].Value.ToString();
        }

        
    }
}
