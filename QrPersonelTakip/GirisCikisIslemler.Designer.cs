namespace QrPersonelTakip
{
    partial class GirisCikisIslemler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKameralar = new System.Windows.Forms.ComboBox();
            this.btnKamera = new System.Windows.Forms.Button();
            this.pictureBoxKamera = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPersonelDepartman = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonelMeslek = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPersonelTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewIslem = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kameralar :";
            // 
            // cmbKameralar
            // 
            this.cmbKameralar.FormattingEnabled = true;
            this.cmbKameralar.Location = new System.Drawing.Point(88, 5);
            this.cmbKameralar.Name = "cmbKameralar";
            this.cmbKameralar.Size = new System.Drawing.Size(202, 21);
            this.cmbKameralar.TabIndex = 1;
            // 
            // btnKamera
            // 
            this.btnKamera.Location = new System.Drawing.Point(296, 5);
            this.btnKamera.Name = "btnKamera";
            this.btnKamera.Size = new System.Drawing.Size(93, 23);
            this.btnKamera.TabIndex = 2;
            this.btnKamera.Text = "Başla";
            this.btnKamera.UseVisualStyleBackColor = true;
            this.btnKamera.Click += new System.EventHandler(this.btnKamera_Click);
            // 
            // pictureBoxKamera
            // 
            this.pictureBoxKamera.Location = new System.Drawing.Point(13, 30);
            this.pictureBoxKamera.Name = "pictureBoxKamera";
            this.pictureBoxKamera.Size = new System.Drawing.Size(376, 381);
            this.pictureBoxKamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKamera.TabIndex = 3;
            this.pictureBoxKamera.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPersonelDepartman);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPersonelMeslek);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPersonelTc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPersonelSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBoxResim);
            this.groupBox1.Controls.Add(this.txtPersonelAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(395, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 151);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel";
            // 
            // txtPersonelDepartman
            // 
            this.txtPersonelDepartman.Enabled = false;
            this.txtPersonelDepartman.Location = new System.Drawing.Point(87, 121);
            this.txtPersonelDepartman.Name = "txtPersonelDepartman";
            this.txtPersonelDepartman.Size = new System.Drawing.Size(167, 20);
            this.txtPersonelDepartman.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Departman :";
            // 
            // txtPersonelMeslek
            // 
            this.txtPersonelMeslek.Enabled = false;
            this.txtPersonelMeslek.Location = new System.Drawing.Point(87, 95);
            this.txtPersonelMeslek.Name = "txtPersonelMeslek";
            this.txtPersonelMeslek.Size = new System.Drawing.Size(167, 20);
            this.txtPersonelMeslek.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Meslek :";
            // 
            // txtPersonelTc
            // 
            this.txtPersonelTc.Enabled = false;
            this.txtPersonelTc.Location = new System.Drawing.Point(87, 69);
            this.txtPersonelTc.Name = "txtPersonelTc";
            this.txtPersonelTc.Size = new System.Drawing.Size(167, 20);
            this.txtPersonelTc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "T.C. :";
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Enabled = false;
            this.txtPersonelSoyad.Location = new System.Drawing.Point(87, 43);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(167, 20);
            this.txtPersonelSoyad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad :";
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.Location = new System.Drawing.Point(260, 12);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(127, 129);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim.TabIndex = 2;
            this.pictureBoxResim.TabStop = false;
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Enabled = false;
            this.txtPersonelAd.Location = new System.Drawing.Point(87, 17);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(167, 20);
            this.txtPersonelAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
            // 
            // dataGridViewIslem
            // 
            this.dataGridViewIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIslem.Location = new System.Drawing.Point(395, 187);
            this.dataGridViewIslem.Name = "dataGridViewIslem";
            this.dataGridViewIslem.Size = new System.Drawing.Size(393, 224);
            this.dataGridViewIslem.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(501, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Durum :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(594, 5);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(60, 25);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "Pasif";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // GirisCikisIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewIslem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxKamera);
            this.Controls.Add(this.btnKamera);
            this.Controls.Add(this.cmbKameralar);
            this.Controls.Add(this.label1);
            this.Name = "GirisCikisIslemler";
            this.Text = "GirisCikisIslemler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GirisCikisIslemler_FormClosed);
            this.Load += new System.EventHandler(this.GirisCikisIslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKameralar;
        private System.Windows.Forms.Button btnKamera;
        private System.Windows.Forms.PictureBox pictureBoxKamera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPersonelDepartman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonelMeslek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPersonelTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewIslem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Timer timer2;
    }
}