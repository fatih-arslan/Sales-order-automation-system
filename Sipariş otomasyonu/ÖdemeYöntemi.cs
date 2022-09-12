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
    public partial class ÖdemeYöntemi : Form
    {        
        public ÖdemeYöntemi()
        {
            InitializeComponent();
        }

        private void buttonKart_Click(object sender, EventArgs e)
        {
            KartlaÖdeme kö = new KartlaÖdeme();
            kö.Show();
            this.Hide();
        }

        private void buttonNakit_Click(object sender, EventArgs e)
        {
            string user = Kullanıcı_Girişi.müşteri.KullanıcıAdı;            
            Kullanıcı_Girişi.müşteri.Sipariş = new Sipariş { SiparişDetayı = new SiparişDetayı { Ürünler = new List<Ürün>(), ToplamAğırlık = 0, ToplamTutar = 0 } };
            
            SqlCommand commandCost = new SqlCommand($"Select Sum(Tutar) from {user}Sepet", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            Kullanıcı_Girişi.müşteri.Sipariş.SiparişDetayı.ToplamTutar = (double)commandCost.ExecuteScalar();
            
            SqlCommand commandWeight = new SqlCommand($"Select sum(Ağırlık) from {user}Sepet", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            Kullanıcı_Girişi.müşteri.Sipariş.SiparişDetayı.ToplamAğırlık = double.Parse(commandWeight.ExecuteScalar().ToString());

            Kullanıcı_Girişi.müşteri.Sipariş.ÖdemeYöntemi = new Nakit() {AlınanNakit = Kullanıcı_Girişi.müşteri.Sipariş.SiparişDetayı.ToplamTutar };
            Kullanıcı_Girişi.müşteri.Sipariş.Durum = "Hazırlanıyor";
            Kullanıcı_Girişi.müşteri.Sipariş.Tarih = DateTime.Now;

            SqlCommand commandGet1 = new SqlCommand($"Select * from {user}Sepet", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            SqlDataAdapter da = new SqlDataAdapter(commandGet1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            Kullanıcı_Girişi.müşteri.Sipariş.SiparişDetayı.Ürünler.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {                                
                string Ad = dt.Rows[i]["Ürün"].ToString();
                SqlCommand commandGet2 = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);                
                Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                commandGet2.Parameters.AddWithValue("@Ürün", Ad);
                SqlDataAdapter da2 = new SqlDataAdapter(commandGet2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                string Fiyat = dt.Rows[i]["Fiyat"].ToString();
                string Ağırlık = dt.Rows[i]["Ağırlık"].ToString();
                string Adet = dt.Rows[i]["Adet"].ToString();
                string Stok = dt2.Rows[0]["Stok"].ToString();
                Ürün ürün = new Ürün { Ad = Ad, Fiyat = float.Parse(Fiyat), Ağırlık = float.Parse(Ağırlık), SeçilenAdet = int.Parse(Adet), Stok = int.Parse(Stok) };
                Kullanıcı_Girişi.müşteri.Sipariş.SiparişDetayı.Ürünler.Add(ürün);
            }

            foreach (Ürün a in Kullanıcı_Girişi.müşteri.Sipariş.SiparişDetayı.Ürünler)
            {
                a.Stok -= a.SeçilenAdet;
                SqlCommand commandUpdate = new SqlCommand("Update Ürünler set Stok = @Stok where Ürün = @Ürün", Sqlİşlemleri.connection);
                Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                commandUpdate.Parameters.AddWithValue("@Ürün", a.Ad);
                commandUpdate.Parameters.AddWithValue("@Stok", a.Stok);
                commandUpdate.ExecuteNonQuery();
            }

            SqlCommand commandAdd = new SqlCommand("Insert into Siparişler (KullanıcıAdı, Tarih, Tutar, Ağırlık, Durum, Ürünler) values (@KullanıcıAdı, @Tarih, @Tutar, @Ağırlık, @Durum, @Ürünler)", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            commandAdd.Parameters.AddWithValue("@KullanıcıAdı", user);
            commandAdd.Parameters.AddWithValue("@Tarih", Kullanıcı_Girişi.müşteri.Sipariş.Tarih.ToString("d/M/yyyy"));
            commandAdd.Parameters.AddWithValue("@Tutar", Kullanıcı_Girişi.müşteri.Sipariş.SiparişDetayı.ToplamTutar);
            commandAdd.Parameters.AddWithValue("@Ağırlık", Kullanıcı_Girişi.müşteri.Sipariş.SiparişDetayı.ToplamAğırlık);
            commandAdd.Parameters.AddWithValue("@Durum", Kullanıcı_Girişi.müşteri.Sipariş.Durum);
            commandAdd.Parameters.AddWithValue("@Ürünler", Kullanıcı_Girişi.müşteri.Sipariş.SiparişDetayı.ToString());
            commandAdd.ExecuteNonQuery();

            SqlCommand command1 = new SqlCommand("Select SiparişKodu from Siparişler", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string k = table.Rows[table.Rows.Count - 1]["SiparişKodu"].ToString();
            Kullanıcı_Girişi.müşteri.Sipariş.Kod = int.Parse(k);

            SqlCommand commandDelete = new SqlCommand($"Drop table {user}Sepet", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            commandDelete.ExecuteNonQuery();
            this.Hide();
            Kullanıcı_Girişi.müşteri.Sipariş = null;
            MessageBox.Show("Siparişiniz oluşturuldu.");
        }

        private void buttonÇek_Click(object sender, EventArgs e)
        {
            ÇekleÖdeme çö = new ÇekleÖdeme();
            çö.Show();
            this.Hide();
        }
    }
}
