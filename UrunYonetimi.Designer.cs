namespace HW2_StokTakip
{
    partial class UrunYonetimi
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
            this.gbUrunKayitFormu = new System.Windows.Forms.GroupBox();
            this.rtbUrunOzellikleri = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.UrunDurumu = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunMarkasi = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.gbUrunKayitFormu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUrunKayitFormu
            // 
            this.gbUrunKayitFormu.BackColor = System.Drawing.Color.MintCream;
            this.gbUrunKayitFormu.Controls.Add(this.txtStok);
            this.gbUrunKayitFormu.Controls.Add(this.label2);
            this.gbUrunKayitFormu.Controls.Add(this.btnSil);
            this.gbUrunKayitFormu.Controls.Add(this.btnGuncelle);
            this.gbUrunKayitFormu.Controls.Add(this.btnEkle);
            this.gbUrunKayitFormu.Controls.Add(this.rtbUrunOzellikleri);
            this.gbUrunKayitFormu.Controls.Add(this.label6);
            this.gbUrunKayitFormu.Controls.Add(this.cbDurum);
            this.gbUrunKayitFormu.Controls.Add(this.UrunDurumu);
            this.gbUrunKayitFormu.Controls.Add(this.txtUrunFiyati);
            this.gbUrunKayitFormu.Controls.Add(this.txtUrunMarkasi);
            this.gbUrunKayitFormu.Controls.Add(this.txtUrunAdi);
            this.gbUrunKayitFormu.Controls.Add(this.label5);
            this.gbUrunKayitFormu.Controls.Add(this.label4);
            this.gbUrunKayitFormu.Controls.Add(this.label3);
            this.gbUrunKayitFormu.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbUrunKayitFormu.Location = new System.Drawing.Point(76, 367);
            this.gbUrunKayitFormu.Name = "gbUrunKayitFormu";
            this.gbUrunKayitFormu.Size = new System.Drawing.Size(792, 179);
            this.gbUrunKayitFormu.TabIndex = 2;
            this.gbUrunKayitFormu.TabStop = false;
            this.gbUrunKayitFormu.Text = "Ürün Girişi";
            // 
            // rtbUrunOzellikleri
            // 
            this.rtbUrunOzellikleri.Location = new System.Drawing.Point(566, 65);
            this.rtbUrunOzellikleri.Name = "rtbUrunOzellikleri";
            this.rtbUrunOzellikleri.Size = new System.Drawing.Size(215, 91);
            this.rtbUrunOzellikleri.TabIndex = 11;
            this.rtbUrunOzellikleri.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ürün Özellikleri";
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(410, 73);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(74, 28);
            this.cbDurum.TabIndex = 9;
            this.cbDurum.Text = "Aktif";
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // UrunDurumu
            // 
            this.UrunDurumu.AutoSize = true;
            this.UrunDurumu.Location = new System.Drawing.Point(333, 73);
            this.UrunDurumu.Name = "UrunDurumu";
            this.UrunDurumu.Size = new System.Drawing.Size(71, 24);
            this.UrunDurumu.TabIndex = 7;
            this.UrunDurumu.Text = "Durum";
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(125, 104);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(100, 32);
            this.txtUrunFiyati.TabIndex = 5;
            // 
            // txtUrunMarkasi
            // 
            this.txtUrunMarkasi.Location = new System.Drawing.Point(125, 65);
            this.txtUrunMarkasi.Name = "txtUrunMarkasi";
            this.txtUrunMarkasi.Size = new System.Drawing.Size(100, 32);
            this.txtUrunMarkasi.TabIndex = 4;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(125, 28);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 32);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Markası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mevcut Ürünler";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(76, 97);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(792, 240);
            this.dgvUrunler.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(250, 119);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 37);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(351, 119);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(103, 36);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(460, 120);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 36);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Stok Sayısı";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(410, 32);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 32);
            this.txtStok.TabIndex = 16;
            // 
            // UrunYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(957, 577);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbUrunKayitFormu);
            this.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UrunYonetimi";
            this.Text = "UrunYonetimi";
            this.Load += new System.EventHandler(this.UrunYonetimi_Load);
            this.gbUrunKayitFormu.ResumeLayout(false);
            this.gbUrunKayitFormu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUrunKayitFormu;
        private System.Windows.Forms.RichTextBox rtbUrunOzellikleri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.Label UrunDurumu;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunMarkasi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label2;
    }
}