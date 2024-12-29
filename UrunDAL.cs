﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HW2_StokTakip
{
    internal class UrunDAL
    {
        SqlConnection conn = new SqlConnection("server = .; database = AdoNetDb; trusted_connection = true;");

        void BaglantiyiAc()
        {
            if (conn.State == ConnectionState.Closed) // eğer sql bağlantımız kapalıysa 
            {
                conn.Open(); // bağlantıyı aç
            }
        }

        public List<Urun> UrunleriGetir()
        {
            List<Urun> urunler = new List<Urun>(); // boş liste oluştur.
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from Urunler", conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Urun urun = new Urun
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Description = Convert.ToString(reader["Description"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    Stock = Convert.ToInt32(reader["Stock"]),
                    IsActive = reader.GetBoolean(5),
                    
                };
                urunler.Add(urun);

            }
            reader.Close();
            sqlCommand.Dispose();
            conn.Close();
            return urunler;
        }
    }
}
