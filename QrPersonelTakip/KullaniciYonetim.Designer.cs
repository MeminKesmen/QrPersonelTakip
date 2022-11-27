namespace QrPersonelTakip
{
    partial class KullaniciYonetim
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYetkiId = new System.Windows.Forms.TextBox();
            this.btnYetkiEkle = new System.Windows.Forms.Button();
            this.txtYetkiAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYetkiGuncelle = new System.Windows.Forms.Button();
            this.btnYetkiSil = new System.Windows.Forms.Button();
            this.btnYetkiTemizle = new System.Windows.Forms.Button();
            this.dataGridViewYetkiler = new System.Windows.Forms.DataGridView();
            this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonelAra = new System.Windows.Forms.TextBox();
            this.txtKullaniciId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPersoneller = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.cmbYetkiler = new System.Windows.Forms.ComboBox();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnKullaniciGuncelle = new System.Windows.Forms.Button();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.btnKullaniciTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYetkiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewYetkiler);
            this.groupBox1.Controls.Add(this.btnYetkiTemizle);
            this.groupBox1.Controls.Add(this.btnYetkiSil);
            this.groupBox1.Controls.Add(this.btnYetkiGuncelle);
            this.groupBox1.Controls.Add(this.txtYetkiAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnYetkiEkle);
            this.groupBox1.Controls.Add(this.txtYetkiId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetki";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKullaniciTemizle);
            this.groupBox2.Controls.Add(this.btnKullaniciSil);
            this.groupBox2.Controls.Add(this.btnKullaniciGuncelle);
            this.groupBox2.Controls.Add(this.btnKullaniciEkle);
            this.groupBox2.Controls.Add(this.cmbYetkiler);
            this.groupBox2.Controls.Add(this.txtKullaniciSifre);
            this.groupBox2.Controls.Add(this.txtKullaniciAd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbPersoneller);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtKullaniciId);
            this.groupBox2.Controls.Add(this.txtPersonelAra);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridViewKullanicilar);
            this.groupBox2.Location = new System.Drawing.Point(412, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 496);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // txtYetkiId
            // 
            this.txtYetkiId.Location = new System.Drawing.Point(144, 24);
            this.txtYetkiId.Name = "txtYetkiId";
            this.txtYetkiId.Size = new System.Drawing.Size(152, 20);
            this.txtYetkiId.TabIndex = 1;
            // 
            // btnYetkiEkle
            // 
            this.btnYetkiEkle.Location = new System.Drawing.Point(17, 103);
            this.btnYetkiEkle.Name = "btnYetkiEkle";
            this.btnYetkiEkle.Size = new System.Drawing.Size(79, 36);
            this.btnYetkiEkle.TabIndex = 2;
            this.btnYetkiEkle.Text = "Ekle";
            this.btnYetkiEkle.UseVisualStyleBackColor = true;
            this.btnYetkiEkle.Click += new System.EventHandler(this.btnYetkiEkle_Click);
            // 
            // txtYetkiAd
            // 
            this.txtYetkiAd.Location = new System.Drawing.Point(144, 66);
            this.txtYetkiAd.Name = "txtYetkiAd";
            this.txtYetkiAd.Size = new System.Drawing.Size(152, 20);
            this.txtYetkiAd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad :";
            // 
            // btnYetkiGuncelle
            // 
            this.btnYetkiGuncelle.Location = new System.Drawing.Point(102, 103);
            this.btnYetkiGuncelle.Name = "btnYetkiGuncelle";
            this.btnYetkiGuncelle.Size = new System.Drawing.Size(79, 36);
            this.btnYetkiGuncelle.TabIndex = 5;
            this.btnYetkiGuncelle.Text = "Guncelle";
            this.btnYetkiGuncelle.UseVisualStyleBackColor = true;
            this.btnYetkiGuncelle.Click += new System.EventHandler(this.btnYetkiGuncelle_Click);
            // 
            // btnYetkiSil
            // 
            this.btnYetkiSil.Location = new System.Drawing.Point(187, 103);
            this.btnYetkiSil.Name = "btnYetkiSil";
            this.btnYetkiSil.Size = new System.Drawing.Size(79, 36);
            this.btnYetkiSil.TabIndex = 6;
            this.btnYetkiSil.Text = "Sil";
            this.btnYetkiSil.UseVisualStyleBackColor = true;
            this.btnYetkiSil.Click += new System.EventHandler(this.btnYetkiSil_Click);
            // 
            // btnYetkiTemizle
            // 
            this.btnYetkiTemizle.Location = new System.Drawing.Point(272, 103);
            this.btnYetkiTemizle.Name = "btnYetkiTemizle";
            this.btnYetkiTemizle.Size = new System.Drawing.Size(79, 36);
            this.btnYetkiTemizle.TabIndex = 7;
            this.btnYetkiTemizle.Text = "Temizle";
            this.btnYetkiTemizle.UseVisualStyleBackColor = true;
            this.btnYetkiTemizle.Click += new System.EventHandler(this.btnYetkiTemizle_Click);
            // 
            // dataGridViewYetkiler
            // 
            this.dataGridViewYetkiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYetkiler.Location = new System.Drawing.Point(6, 224);
            this.dataGridViewYetkiler.Name = "dataGridViewYetkiler";
            this.dataGridViewYetkiler.Size = new System.Drawing.Size(364, 266);
            this.dataGridViewYetkiler.TabIndex = 8;
            this.dataGridViewYetkiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewYetkiler_CellClick);
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(6, 224);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(364, 266);
            this.dataGridViewKullanicilar.TabIndex = 17;
            this.dataGridViewKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKullanicilar_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Personel Ara :";
            // 
            // txtPersonelAra
            // 
            this.txtPersonelAra.Location = new System.Drawing.Point(60, 32);
            this.txtPersonelAra.Name = "txtPersonelAra";
            this.txtPersonelAra.Size = new System.Drawing.Size(152, 20);
            this.txtPersonelAra.TabIndex = 19;
            this.txtPersonelAra.TextChanged += new System.EventHandler(this.txtPersonelAra_TextChanged);
            // 
            // txtKullaniciId
            // 
            this.txtKullaniciId.Location = new System.Drawing.Point(287, 32);
            this.txtKullaniciId.Name = "txtKullaniciId";
            this.txtKullaniciId.Size = new System.Drawing.Size(72, 20);
            this.txtKullaniciId.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Id :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Personel Seç :";
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(19, 71);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(231, 21);
            this.cmbPersoneller.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kullanıcı Ad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Kullanıcı Sifre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Kullanıcı Yetki :";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(98, 96);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(152, 20);
            this.txtKullaniciAd.TabIndex = 27;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(98, 131);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(152, 20);
            this.txtKullaniciSifre.TabIndex = 28;
            // 
            // cmbYetkiler
            // 
            this.cmbYetkiler.FormattingEnabled = true;
            this.cmbYetkiler.Location = new System.Drawing.Point(98, 162);
            this.cmbYetkiler.Name = "cmbYetkiler";
            this.cmbYetkiler.Size = new System.Drawing.Size(152, 21);
            this.cmbYetkiler.TabIndex = 29;
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(287, 66);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(72, 26);
            this.btnKullaniciEkle.TabIndex = 30;
            this.btnKullaniciEkle.Text = "Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnKullaniciGuncelle
            // 
            this.btnKullaniciGuncelle.Location = new System.Drawing.Point(287, 98);
            this.btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            this.btnKullaniciGuncelle.Size = new System.Drawing.Size(72, 26);
            this.btnKullaniciGuncelle.TabIndex = 31;
            this.btnKullaniciGuncelle.Text = "Guncelle";
            this.btnKullaniciGuncelle.UseVisualStyleBackColor = true;
            this.btnKullaniciGuncelle.Click += new System.EventHandler(this.btnKullaniciGuncelle_Click);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(287, 130);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(72, 26);
            this.btnKullaniciSil.TabIndex = 32;
            this.btnKullaniciSil.Text = "Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // btnKullaniciTemizle
            // 
            this.btnKullaniciTemizle.Location = new System.Drawing.Point(287, 162);
            this.btnKullaniciTemizle.Name = "btnKullaniciTemizle";
            this.btnKullaniciTemizle.Size = new System.Drawing.Size(72, 26);
            this.btnKullaniciTemizle.TabIndex = 33;
            this.btnKullaniciTemizle.Text = "Temizle";
            this.btnKullaniciTemizle.UseVisualStyleBackColor = true;
            this.btnKullaniciTemizle.Click += new System.EventHandler(this.btnKullaniciTemizle_Click);
            // 
            // KullaniciYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KullaniciYonetim";
            this.Text = "KullaniciYonetim";
            this.Load += new System.EventHandler(this.KullaniciYonetim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYetkiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewYetkiler;
        private System.Windows.Forms.Button btnYetkiTemizle;
        private System.Windows.Forms.Button btnYetkiSil;
        private System.Windows.Forms.Button btnYetkiGuncelle;
        private System.Windows.Forms.TextBox txtYetkiAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYetkiEkle;
        private System.Windows.Forms.TextBox txtYetkiId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKullaniciTemizle;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnKullaniciGuncelle;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.ComboBox cmbYetkiler;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPersoneller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullaniciId;
        private System.Windows.Forms.TextBox txtPersonelAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
    }
}