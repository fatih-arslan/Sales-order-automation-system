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
    public partial class Kullanıcı_Ekranı : Form
    {
        public static List<Sipariş> siparişler = new List<Sipariş>();
        public Kullanıcı_Ekranı()
        {
            InitializeComponent();
        }

        private void Kullanıcı_Ekranı_Load(object sender, EventArgs e)
        {
            this.Height = 720;
            this.Width = 1200;
            this.StartPosition = FormStartPosition.CenterScreen;
            SqlCommand commandGet = new SqlCommand("Select Ürün from Ürünler", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            SqlDataReader reader = commandGet.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Ürün", typeof(string));
            dt.Load(reader);
            comboBoxDigerÜrün.ValueMember = "Ürün";
            comboBoxDigerÜrün.DataSource = dt;
            
            SqlCommand getMasaüstü = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            getMasaüstü.Parameters.AddWithValue("@Ürün", "Masaüstü Bilgisayar");
            SqlDataReader reader2 = getMasaüstü.ExecuteReader();
            using(reader2)
            {
                if(reader2.Read())
                {
                    MasaüstüFiyat.Text = reader2["Fiyat"].ToString() + "₺";
                    MasaüstüAğırlık.Text = reader2["Ağırlık"].ToString() + "kg";
                    MasaüstüStok.Text = reader2["Stok"].ToString();
                }
            }

            SqlCommand getDizüstü = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            getDizüstü.Parameters.AddWithValue("@Ürün", "Dizüstü Bilgisayar");
            SqlDataReader reader3 = getDizüstü.ExecuteReader();
            using (reader3)
            {
                if (reader3.Read())
                {
                    DizüstüFiyat.Text = reader3["Fiyat"].ToString() + "₺";
                    DizüstüAğırlık.Text = reader3["Ağırlık"].ToString() + "kg";
                    DizüstüStok.Text = reader3["Stok"].ToString();
                }
            }

            SqlCommand getTel = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            getTel.Parameters.AddWithValue("@Ürün", "Cep Telefonu");
            SqlDataReader reader4 = getTel.ExecuteReader();
            using (reader4)
            {
                if (reader4.Read())
                {
                    TelFiyat.Text = reader4["Fiyat"].ToString() + "₺";
                    TelAğırlık.Text = reader4["Ağırlık"].ToString() + "kg";
                    TelStok.Text = reader4["Stok"].ToString();
                }
            }

            SqlCommand getTablet = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            getTablet.Parameters.AddWithValue("@Ürün", "Tablet");
            SqlDataReader reader5 = getTablet.ExecuteReader();
            using (reader5)
            {
                if (reader5.Read())
                {
                    TabletFiyat.Text = reader5["Fiyat"].ToString() + "₺";
                    TabletAğırlık.Text = reader5["Ağırlık"].ToString() + "kg";
                    TabletStok.Text = reader5["Stok"].ToString();
                }
            }

            SqlCommand getFoto = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            getFoto.Parameters.AddWithValue("@Ürün", "Fotoğraf Makinesi");
            SqlDataReader reader6 = getFoto.ExecuteReader();
            using (reader6)
            {
                if (reader6.Read())
                {
                    FotoFiyat.Text = reader6["Fiyat"].ToString() + "₺";
                    FotoAğırlık.Text = reader6["Ağırlık"].ToString() + "kg";
                    FotoStok.Text = reader6["Stok"].ToString();
                }
            }

            SqlCommand getYazıcı = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            getYazıcı.Parameters.AddWithValue("@Ürün", "Yazıcı");
            SqlDataReader reader7 = getYazıcı.ExecuteReader();
            using (reader7)
            {
                if (reader7.Read())
                {
                    YazıcıFiyat.Text = reader7["Fiyat"].ToString() + "₺";
                    YazıcıAğırlık.Text = reader7["Ağırlık"].ToString() + "kg";
                    YazıcıStok.Text = reader7["Stok"].ToString();
                }
            }

            SqlCommand getX = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            getX.Parameters.AddWithValue("@Ürün", "Xbox");
            SqlDataReader reader8 = getX.ExecuteReader();
            using (reader8)
            {
                if (reader8.Read())
                {
                    XFiyat.Text = reader8["Fiyat"].ToString() + "₺";
                    XAğırlık.Text = reader8["Ağırlık"].ToString() + "kg";
                    XStok.Text = reader8["Stok"].ToString();
                }
            }

            SqlCommand getP = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            getP.Parameters.AddWithValue("@Ürün", "Playstation");
            SqlDataReader reader9 = getP.ExecuteReader();
            using (reader9)
            {
                if (reader9.Read())
                {
                    PFiyat.Text = reader9["Fiyat"].ToString() + "₺";
                    PAğırlık.Text = reader9["Ağırlık"].ToString() + "kg";
                    PStok.Text = reader9["Stok"].ToString();
                }
            }
        }

        private void radioButtonTablet_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSeçiliÜrün.Text = "Tablet";
        }

        private void radioButtonYazıcı_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSeçiliÜrün.Text = "Yazıcı";
        }

        private void radioButtonMasaüstüBilgisayar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSeçiliÜrün.Text = "Masaüstü Bilgisayar";
        }

        private void radioButtonDizüstüBilgisayar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSeçiliÜrün.Text = "Dizüstü Bilgisayar";
        }

        private void radioButtonCepTelefonu_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSeçiliÜrün.Text = "Cep Telefonu";
        }

        private void radioButtonFotoğrafMakinesi_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSeçiliÜrün.Text = "Fotoğraf Makinesi";
        }

        private void radioButtonXbox_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSeçiliÜrün.Text = "Xbox";
        }

        private void radioButtonPlaystation_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSeçiliÜrün.Text = "Playstation";
        }

        private void comboBoxDigerÜrün_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSeçiliÜrün.Text = comboBoxDigerÜrün.SelectedValue.ToString();
        }    

        private void buttonSepeteEkle_Click(object sender, EventArgs e)
        {
            
            if(textBoxAdet.Text == String.Empty)
            {
                MessageBox.Show("Lütfen adet giriniz.");
            }
            else
            {                             
                Ürün ürün = new Ürün { Ad = textBoxSeçiliÜrün.Text, SeçilenAdet = int.Parse(textBoxAdet.Text) };
                SqlCommand commandGet = new SqlCommand("Select * from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
                commandGet.Parameters.AddWithValue("@Ürün", ürün.Ad);
                Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                SqlDataReader reader = commandGet.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        ürün.Fiyat = float.Parse(reader["Fiyat"].ToString());
                        ürün.Ağırlık = float.Parse(reader["Ağırlık"].ToString());
                        ürün.Stok = int.Parse(reader["Stok"].ToString());
                    }
                }
                
                if (ürün.SeçilenAdet > ürün.Stok)
                {
                    MessageBox.Show("Stokta yeterli ürün yok, lütfen başka bir adet giriniz.");
                }
                else
                {                  
                    try
                    {
                        string user = Kullanıcı_Girişi.müşteri.KullanıcıAdı;
                        SqlCommand command1 = new SqlCommand($"Create table {user}Sepet (Ürün nchar(30), Fiyat nchar(50), Ağırlık decimal(7,3), Adet nchar(30), Tutar float)", Sqlİşlemleri.connection);
                        Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                        command1.ExecuteNonQuery();

                        SqlCommand command2 = new SqlCommand($"Insert into {user}Sepet (Ürün, Fiyat, Ağırlık, Adet, Tutar) values (@Ürün, @Fiyat, @Ağırlık, @Adet, @Tutar)", Sqlİşlemleri.connection);
                        Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                        command2.Parameters.AddWithValue("@Ürün", ürün.Ad);
                        command2.Parameters.AddWithValue("@Fiyat", ürün.Fiyat);
                        command2.Parameters.AddWithValue("@Ağırlık", ürün.Ağırlık*ürün.SeçilenAdet);
                        command2.Parameters.AddWithValue("@Adet", ürün.SeçilenAdet);
                        command2.Parameters.AddWithValue("@Tutar", ürün.Fiyat*ürün.SeçilenAdet);
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Ürün eklendi.");
                    }
                    catch (Exception)
                    {
                        string user = Kullanıcı_Girişi.müşteri.KullanıcıAdı;

                        SqlCommand commandCheck = new SqlCommand($"Select * from {user}Sepet where Ürün = @Ürün", Sqlİşlemleri.connection);
                        Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                        commandCheck.Parameters.AddWithValue("@Ürün", ürün.Ad);
                        SqlDataAdapter da = new SqlDataAdapter(commandCheck);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if(dt.Rows.Count > 0)
                        {
                            SqlCommand commandUpdate = new SqlCommand($"Update {user}Sepet set Adet = @Adet, Tutar = @Tutar, Ağırlık = @Ağırlık where Ürün = @Ürün", Sqlİşlemleri.connection);
                            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                            string yeniTutar = (float.Parse(dt.Rows[0]["Tutar"].ToString()) + ürün.SeçilenAdet * ürün.Fiyat).ToString();
                            string yeniAdet = (int.Parse(dt.Rows[0]["Adet"].ToString()) + ürün.SeçilenAdet).ToString();
                            string yeniAğırlık = (float.Parse(dt.Rows[0]["Ağırlık"].ToString()) + (ürün.SeçilenAdet * ürün.Ağırlık)).ToString();
                            commandUpdate.Parameters.AddWithValue("@Ürün", ürün.Ad);
                            commandUpdate.Parameters.AddWithValue("@Tutar", float.Parse(yeniTutar));
                            commandUpdate.Parameters.AddWithValue("@Adet", yeniAdet);
                            commandUpdate.Parameters.AddWithValue("@Ağırlık", float.Parse(yeniAğırlık));
                            commandUpdate.ExecuteNonQuery();
                        }
                        else
                        {
                            SqlCommand command2 = new SqlCommand($"Insert into {user}Sepet (Ürün, Fiyat, Ağırlık, Adet, Tutar) values (@Ürün, @Fiyat, @Ağırlık, @Adet, @Tutar)", Sqlİşlemleri.connection);
                            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                            command2.Parameters.AddWithValue("@Ürün", ürün.Ad);
                            command2.Parameters.AddWithValue("@Fiyat", ürün.Fiyat);
                            command2.Parameters.AddWithValue("@Ağırlık", ürün.Ağırlık * ürün.SeçilenAdet);
                            command2.Parameters.AddWithValue("@Adet", ürün.SeçilenAdet);
                            command2.Parameters.AddWithValue("@Tutar", ürün.Fiyat * ürün.SeçilenAdet);
                            command2.ExecuteNonQuery();
                        }                                               
                        MessageBox.Show("Ürün eklendi.");
                    }
                }                
            }            
            
        }

        private void buttonSepetim_Click(object sender, EventArgs e)
        {
            Sepet s = new Sepet();
            s.Show();
        }

        private void buttonSipariş_Click(object sender, EventArgs e)
        {
            KullanıcıSiparişEkranı kse = new KullanıcıSiparişEkranı();
            kse.Show();
        }
    }
}
