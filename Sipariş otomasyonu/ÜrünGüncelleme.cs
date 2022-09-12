using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sipariş_otomasyonu
{
    public partial class ÜrünGüncelleme : Form
    {
        public ÜrünGüncelleme()
        {
            InitializeComponent();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            string ad = comboBoxÜrünler.SelectedValue.ToString();
            string fiyat = textBoxFiyat.Text;
            double ağırlık = float.Parse(textBoxAğırlık.Text);
            string stok = textBoxStok.Text;
            SqlCommand commandUpdate = new SqlCommand("Update Ürünler set Fiyat = @Fiyat, Ağırlık = @Ağırlık, Stok = @Stok where Ürün = @Ürün",Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            commandUpdate.Parameters.AddWithValue("@Fiyat", fiyat);
            commandUpdate.Parameters.AddWithValue("@Ağırlık", ağırlık);
            commandUpdate.Parameters.AddWithValue("@Stok", stok);
            commandUpdate.Parameters.AddWithValue("@Ürün", ad);
            commandUpdate.ExecuteNonQuery();
            MessageBox.Show("Ürün güncellendi");
        }

        private void ÜrünGüncelleme_Load(object sender, EventArgs e)
        {
            SqlCommand commandGet = new SqlCommand("Select Ürün from Ürünler", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            SqlDataReader reader = commandGet.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Ürün", typeof(string));
            dt.Load(reader);
            comboBoxÜrünler.ValueMember = "Ürün";
            comboBoxÜrünler.DataSource = dt;

        }

        private void buttonBilgi_Click(object sender, EventArgs e)
        {
            string isim = comboBoxÜrünler.SelectedValue.ToString();
            SqlCommand commandGet = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            commandGet.Parameters.AddWithValue("@Ürün", isim);
            SqlDataReader reader = commandGet.ExecuteReader();
            using (reader)
            {
                if (reader.Read())
                {
                    textBoxFiyat.Text = reader["Fiyat"].ToString();
                    textBoxAğırlık.Text = reader["Ağırlık"].ToString();
                    textBoxStok.Text = reader["Stok"].ToString();
                }
            }
        }
    }
}
