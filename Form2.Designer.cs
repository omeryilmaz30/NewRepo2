namespace HW2_StokTakip
{
    partial class Form2
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
            this.button_KategoriYonetimi = new System.Windows.Forms.Button();
            this.button_UrunYonetimi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_KategoriYonetimi
            // 
            this.button_KategoriYonetimi.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_KategoriYonetimi.Location = new System.Drawing.Point(234, 174);
            this.button_KategoriYonetimi.Name = "button_KategoriYonetimi";
            this.button_KategoriYonetimi.Size = new System.Drawing.Size(158, 92);
            this.button_KategoriYonetimi.TabIndex = 0;
            this.button_KategoriYonetimi.Text = "Kategori Yönetimi";
            this.button_KategoriYonetimi.UseVisualStyleBackColor = true;
            this.button_KategoriYonetimi.Click += new System.EventHandler(this.button_KategoriYonetimi_Click);
            // 
            // button_UrunYonetimi
            // 
            this.button_UrunYonetimi.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_UrunYonetimi.Location = new System.Drawing.Point(462, 174);
            this.button_UrunYonetimi.Name = "button_UrunYonetimi";
            this.button_UrunYonetimi.Size = new System.Drawing.Size(155, 92);
            this.button_UrunYonetimi.TabIndex = 1;
            this.button_UrunYonetimi.Text = "Ürün Yönetimi";
            this.button_UrunYonetimi.UseVisualStyleBackColor = true;
            this.button_UrunYonetimi.Click += new System.EventHandler(this.button_UrunYonetimi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(204, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Merhaba! Ana menüye hoşgeldiniz.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(910, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_UrunYonetimi);
            this.Controls.Add(this.button_KategoriYonetimi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_KategoriYonetimi;
        private System.Windows.Forms.Button button_UrunYonetimi;
        private System.Windows.Forms.Label label1;
    }
}