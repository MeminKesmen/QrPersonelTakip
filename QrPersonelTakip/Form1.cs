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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
namespace QrPersonelTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;
        YetkiManager yetkiManager = new YetkiManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in fico)
            {
                comboBox1 .Items.Add(item.Name);
            }
            comboBox1.SelectedIndex = 0;
        }
        void KameraAcKapa(bool islem)
        {
            if (islem)
            {
                vcd = new VideoCaptureDevice(fico[comboBox1.SelectedIndex].MonikerString);
                vcd.NewFrame += Vcd_NewFrame;
                vcd.Start();
                button1 .Text = "Durdur";
                timer1.Start();
            }
            else
            {
                if (vcd != null)
                {
                    button1.Text = "Başla";
                    vcd.SignalToStop();
                    vcd.NewFrame -= Vcd_NewFrame;
                    vcd = null;
                    timer1.Stop();
                }

            }
        }
        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KameraAcKapa(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
               


                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pictureBox1.Image);
                if (sonuc != null)
                {
                    
                    richTextBox1.Text = sonuc.ToString();
                    timer1.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepartmanYonetim frm = new DepartmanYonetim();
            frm.Show();
        }
    }
}
