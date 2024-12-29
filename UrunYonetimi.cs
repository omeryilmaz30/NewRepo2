using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_StokTakip
{
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection("server = .; database = AdoNetDb; trusted_connection = true;");
        UrunDAL urunDAL = new UrunDAL();

        
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = urunDAL.UrunleriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           /* if(!string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                var urun = new Urun()
                {
                    Name = txtUrunAdi.Text,
                    Stock = Convert.ToInt32(txtStok.Text),
                    Description = rtbUrunOzellikleri.Text,
                    Price = Convert.ToInt32(txtUrunFiyati.Text),
                    IsActive = cbDurum.Checked                   
                };

                BaglantiyiAc();

                SqlCommand sqlCommand = new SqlCommand("insert into Kategoriler (Name, Stock, IsActive, Price, Description) values (@Name, @Stock, @IsActive, @Price, @Description)", conn);
                sqlCommand.Parameters.AddWithValue("@Name", urun.Name);
                sqlCommand.Parameters.AddWithValue("@Stock", urun.Stock);
                sqlCommand.Parameters.AddWithValue("@IsActive", urun.IsActive);
                sqlCommand.Parameters.AddWithValue("@Description", urun.Description);
                sqlCommand.Parameters.AddWithValue("@Price", urun.Price);
                var sonuc = sqlCommand.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    sqlCommand.Dispose();
                    dgvUrunler.DataSource = VerileriYukle();
                    MessageBox.Show("Kayıt başarılı!");
                }
                BaglantiyiKapat();

            }*/
        }
    }
}
