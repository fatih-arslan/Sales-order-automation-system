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
    public partial class ÜrünEkleme : Form
    {
        public ÜrünEkleme()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into Ürünler (Ürün, Fiyat, Ağırlık, Stok) values (@Ürün, @Fiyat, @Ağırlık, @Stok)",Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            commandAdd.Parameters.AddWithValue("@Ürün", textBoxAd.Text);
            commandAdd.Parameters.AddWithValue("@Fiyat", textBoxFiyat.Text);
            commandAdd.Parameters.AddWithValue("@Ağırlık", textBoxAğırlık.Text);
            commandAdd.Parameters.AddWithValue("@Stok", textBoxAdet.Text);
            commandAdd.ExecuteNonQuery();
            MessageBox.Show("Ürün Eklendi");
            ÜrünListesi üe = new ÜrünListesi();
            üe.RefreshPage();
        }
    }
}
