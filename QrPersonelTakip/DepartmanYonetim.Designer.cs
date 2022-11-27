namespace QrPersonelTakip
{
    partial class DepartmanYonetim
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
            this.dataGridViewDepartman = new System.Windows.Forms.DataGridView();
            this.btnDepartmanSil = new System.Windows.Forms.Button();
            this.btnDepartmanGuncelle = new System.Windows.Forms.Button();
            this.txtDepartmanAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDepartmanEkle = new System.Windows.Forms.Button();
            this.txtDepartmanId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartmanlar = new System.Windows.Forms.ComboBox();
            this.dataGridViewMeslek = new System.Windows.Forms.DataGridView();
            this.btnMeslekSil = new System.Windows.Forms.Button();
            this.btnMeslekGuncelle = new System.Windows.Forms.Button();
            this.txtMeslekAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMeslekEkle = new System.Windows.Forms.Button();
            this.txtMeslekId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartman)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeslek)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDepartman);
            this.groupBox1.Controls.Add(this.btnDepartmanSil);
            this.groupBox1.Controls.Add(this.btnDepartmanGuncelle);
            this.groupBox1.Controls.Add(this.txtDepartmanAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDepartmanEkle);
            this.groupBox1.Controls.Add(this.txtDepartmanId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departman";
            // 
            // dataGridViewDepartman
            // 
            this.dataGridViewDepartman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartman.Location = new System.Drawing.Point(7, 166);
            this.dataGridViewDepartman.Name = "dataGridViewDepartman";
            this.dataGridViewDepartman.Size = new System.Drawing.Size(377, 254);
            this.dataGridViewDepartman.TabIndex = 7;
            this.dataGridViewDepartman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartman_CellClick);
            // 
            // btnDepartmanSil
            // 
            this.btnDepartmanSil.Location = new System.Drawing.Point(223, 129);
            this.btnDepartmanSil.Name = "btnDepartmanSil";
            this.btnDepartmanSil.Size = new System.Drawing.Size(69, 23);
            this.btnDepartmanSil.TabIndex = 6;
            this.btnDepartmanSil.Text = "Sil";
            this.btnDepartmanSil.UseVisualStyleBackColor = true;
            this.btnDepartmanSil.Click += new System.EventHandler(this.btnDepartmanSil_Click);
            // 
            // btnDepartmanGuncelle
            // 
            this.btnDepartmanGuncelle.Location = new System.Drawing.Point(148, 129);
            this.btnDepartmanGuncelle.Name = "btnDepartmanGuncelle";
            this.btnDepartmanGuncelle.Size = new System.Drawing.Size(69, 23);
            this.btnDepartmanGuncelle.TabIndex = 5;
            this.btnDepartmanGuncelle.Text = "Guncelle";
            this.btnDepartmanGuncelle.UseVisualStyleBackColor = true;
            this.btnDepartmanGuncelle.Click += new System.EventHandler(this.btnDepartmanGuncelle_Click);
            // 
            // txtDepartmanAd
            // 
            this.txtDepartmanAd.Location = new System.Drawing.Point(158, 70);
            this.txtDepartmanAd.Name = "txtDepartmanAd";
            this.txtDepartmanAd.Size = new System.Drawing.Size(140, 20);
            this.txtDepartmanAd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad :";
            // 
            // btnDepartmanEkle
            // 
            this.btnDepartmanEkle.Location = new System.Drawing.Point(73, 129);
            this.btnDepartmanEkle.Name = "btnDepartmanEkle";
            this.btnDepartmanEkle.Size = new System.Drawing.Size(69, 23);
            this.btnDepartmanEkle.TabIndex = 2;
            this.btnDepartmanEkle.Text = "Ekle";
            this.btnDepartmanEkle.UseVisualStyleBackColor = true;
            this.btnDepartmanEkle.Click += new System.EventHandler(this.btnDepartmanEkle_Click);
            // 
            // txtDepartmanId
            // 
            this.txtDepartmanId.Enabled = false;
            this.txtDepartmanId.Location = new System.Drawing.Point(158, 34);
            this.txtDepartmanId.Name = "txtDepartmanId";
            this.txtDepartmanId.Size = new System.Drawing.Size(140, 20);
            this.txtDepartmanId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbDepartmanlar);
            this.groupBox2.Controls.Add(this.dataGridViewMeslek);
            this.groupBox2.Controls.Add(this.btnMeslekSil);
            this.groupBox2.Controls.Add(this.btnMeslekGuncelle);
            this.groupBox2.Controls.Add(this.txtMeslekAd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnMeslekEkle);
            this.groupBox2.Controls.Add(this.txtMeslekId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(408, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meslek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Departman :";
            // 
            // cmbDepartmanlar
            // 
            this.cmbDepartmanlar.FormattingEnabled = true;
            this.cmbDepartmanlar.Location = new System.Drawing.Point(157, 97);
            this.cmbDepartmanlar.Name = "cmbDepartmanlar";
            this.cmbDepartmanlar.Size = new System.Drawing.Size(140, 21);
            this.cmbDepartmanlar.TabIndex = 16;
            // 
            // dataGridViewMeslek
            // 
            this.dataGridViewMeslek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeslek.Location = new System.Drawing.Point(6, 166);
            this.dataGridViewMeslek.Name = "dataGridViewMeslek";
            this.dataGridViewMeslek.Size = new System.Drawing.Size(377, 254);
            this.dataGridViewMeslek.TabIndex = 15;
            this.dataGridViewMeslek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMeslek_CellClick);
            // 
            // btnMeslekSil
            // 
            this.btnMeslekSil.Location = new System.Drawing.Point(222, 129);
            this.btnMeslekSil.Name = "btnMeslekSil";
            this.btnMeslekSil.Size = new System.Drawing.Size(69, 23);
            this.btnMeslekSil.TabIndex = 14;
            this.btnMeslekSil.Text = "Sil";
            this.btnMeslekSil.UseVisualStyleBackColor = true;
            this.btnMeslekSil.Click += new System.EventHandler(this.btnMeslekSil_Click);
            // 
            // btnMeslekGuncelle
            // 
            this.btnMeslekGuncelle.Location = new System.Drawing.Point(147, 129);
            this.btnMeslekGuncelle.Name = "btnMeslekGuncelle";
            this.btnMeslekGuncelle.Size = new System.Drawing.Size(69, 23);
            this.btnMeslekGuncelle.TabIndex = 13;
            this.btnMeslekGuncelle.Text = "Guncelle";
            this.btnMeslekGuncelle.UseVisualStyleBackColor = true;
            this.btnMeslekGuncelle.Click += new System.EventHandler(this.btnMeslekGuncelle_Click);
            // 
            // txtMeslekAd
            // 
            this.txtMeslekAd.Location = new System.Drawing.Point(157, 70);
            this.txtMeslekAd.Name = "txtMeslekAd";
            this.txtMeslekAd.Size = new System.Drawing.Size(140, 20);
            this.txtMeslekAd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ad :";
            // 
            // btnMeslekEkle
            // 
            this.btnMeslekEkle.Location = new System.Drawing.Point(72, 129);
            this.btnMeslekEkle.Name = "btnMeslekEkle";
            this.btnMeslekEkle.Size = new System.Drawing.Size(69, 23);
            this.btnMeslekEkle.TabIndex = 10;
            this.btnMeslekEkle.Text = "Ekle";
            this.btnMeslekEkle.UseVisualStyleBackColor = true;
            this.btnMeslekEkle.Click += new System.EventHandler(this.btnMeslekEkle_Click);
            // 
            // txtMeslekId
            // 
            this.txtMeslekId.Enabled = false;
            this.txtMeslekId.Location = new System.Drawing.Point(157, 34);
            this.txtMeslekId.Name = "txtMeslekId";
            this.txtMeslekId.Size = new System.Drawing.Size(140, 20);
            this.txtMeslekId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID :";
            // 
            // DepartmanYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepartmanYonetim";
            this.Text = "DepartmanYonetim";
            this.Load += new System.EventHandler(this.DepartmanYonetim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartman)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeslek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDepartman;
        private System.Windows.Forms.Button btnDepartmanSil;
        private System.Windows.Forms.Button btnDepartmanGuncelle;
        private System.Windows.Forms.TextBox txtDepartmanAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDepartmanEkle;
        private System.Windows.Forms.TextBox txtDepartmanId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartmanlar;
        private System.Windows.Forms.DataGridView dataGridViewMeslek;
        private System.Windows.Forms.Button btnMeslekSil;
        private System.Windows.Forms.Button btnMeslekGuncelle;
        private System.Windows.Forms.TextBox txtMeslekAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMeslekEkle;
        private System.Windows.Forms.TextBox txtMeslekId;
        private System.Windows.Forms.Label label4;
    }
}