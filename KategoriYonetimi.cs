using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_StokTakip
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("server = .; database = StokTakipDb; trusted_connection = true;");

        void BaglantiyiAc()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        DataTable VerileriYukle()
        {
            BaglantiyiAc();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Kategoriler" , conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            cmd.Dispose();
            BaglantiyiKapat();
            return dt;
        }
        void BaglantiyiKapat()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();   
            }
        }
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = VerileriYukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                var kategori = new Kategori()
                {
                    CreateDate = DateTime.Now,
                    Name = txtKategoriAdi.Text,
                    IsActive = cbIsActive.Checked,  
                };
                BaglantiyiAc();

                SqlCommand sqlCommand = new SqlCommand("insert into Kategoriler (Name, CreateDate, IsActive) values (@Name, @CreateDate, @IsActive)" , conn);
                sqlCommand.Parameters.AddWithValue("@Name" , kategori.Name);
                sqlCommand.Parameters.AddWithValue("@CreateDate" , kategori.CreateDate);
                sqlCommand.Parameters.AddWithValue("@IsActive", kategori.IsActive);
                var sonuc = sqlCommand.ExecuteNonQuery();

                if(sonuc > 0)
                {
                    sqlCommand.Dispose();
                    dgvKategoriler.DataSource = VerileriYukle();
                    MessageBox.Show("Kayıt başarılı!");
                }
                BaglantiyiKapat();
            }
            else
            {
                MessageBox.Show("Bu alan boş bırakılamaz!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace (txtKategoriAdi.Text))
            {
                var kategori = new Kategori()
                {
                    Name = txtKategoriAdi.Text,
                    Id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value),
                };
                BaglantiyiAc();

                SqlCommand sqlCommand = new SqlCommand("update Kategoriler set Name  = @Name  where Id = @id", conn);
                sqlCommand.Parameters.AddWithValue("@id", kategori.Id);
                sqlCommand.Parameters.AddWithValue("@Name" , kategori.Name);
                var sonuc = sqlCommand.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    sqlCommand.Dispose();
                    dgvKategoriler.DataSource = VerileriYukle();
                    MessageBox.Show("Kayıt güncellendi!");
                }

                BaglantiyiKapat();
            }
            else
            {
                MessageBox.Show("Bu alan boş bırakılamaz!");
            }
        }
        

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = false;
        }

        private void KategoriYonetimi_MouseClick(object sender, MouseEventArgs e)
        {
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            BaglantiyiAc();

            SqlCommand sqlCommand = new SqlCommand("delete from Kategoriler  where Id = @id", conn);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value));
            var sonuc = sqlCommand.ExecuteNonQuery();
            if (sonuc > 0)
            {
                sqlCommand.Dispose();
                dgvKategoriler.DataSource = VerileriYukle();
                MessageBox.Show("Kayıt silindi!");
            }

            BaglantiyiKapat();
        }
    }
}
