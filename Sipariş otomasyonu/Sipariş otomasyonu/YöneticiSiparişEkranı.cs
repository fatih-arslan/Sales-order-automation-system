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
    public partial class YöneticiSiparişEkranı : Form
    {
        public YöneticiSiparişEkranı()
        {
            InitializeComponent();
        }
        public void RefreshPage()
        {
            SqlCommand commandGet = new SqlCommand("Select * from Siparişler", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            SqlDataAdapter da = new SqlDataAdapter(commandGet);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[6].Width = 700;
        }

        private void YöneticiSiparişEkranı_Load(object sender, EventArgs e)
        {
            RefreshPage();          
        }

        private void buttonİptal_Click(object sender, EventArgs e)
        {
            
            string m = dataGridView1.CurrentRow.Cells["SiparişKodu"].Value.ToString();
            string ürün = "";
            string adet = "";
            string stok = "";
            string yeniStok = "";
            SqlCommand command1 = new SqlCommand("Select Ürünler from Siparişler where SiparişKodu = @m", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            command1.Parameters.AddWithValue("@m", m);
            SqlDataAdapter da = new SqlDataAdapter(command1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ürünler = dt.Rows[0]["Ürünler"].ToString();
            string[] s = ürünler.Split(',');
            for (int i = 0; i < s.Length; i++)
            {
                adet = String.Join("", s[i].Where(Char.IsDigit).ToArray());
                ürün = s[i].Replace(adet, " ");
                ürün = ürün.Trim();

                SqlCommand command2 = new SqlCommand("Select Stok from Ürünler where Ürün = @Ürün", Sqlİşlemleri.connection);
                Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                command2.Parameters.AddWithValue("@Ürün", ürün);
                SqlDataReader reader = command2.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        stok = reader["Stok"].ToString();
                        yeniStok = (int.Parse(adet) + int.Parse(stok)).ToString();
                        SqlCommand command3 = new SqlCommand("Update Ürünler set Stok = @Stok where Ürün = @Ürün", Sqlİşlemleri.connection);
                        Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                        command3.Parameters.AddWithValue("@Stok", yeniStok);
                        command3.Parameters.AddWithValue("@Ürün", ürün);
                        reader.Close();
                        command3.ExecuteNonQuery();
                    }
                }
            }
            SqlCommand command4 = new SqlCommand("Update Siparişler set Durum = @Durum where SiparişKodu = @Kod", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            command4.Parameters.AddWithValue("@Durum", "İptal edildi");
            command4.Parameters.AddWithValue("@Kod", m);
            command4.ExecuteNonQuery();            
            RefreshPage();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string m = dataGridView1.CurrentRow.Cells["SiparişKodu"].Value.ToString();
            string durum = "İptal edildi";
            SqlCommand commandGet = new SqlCommand("Select Durum from Siparişler where SiparişKodu = @SiparişKodu and Durum = @Durum", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            commandGet.Parameters.AddWithValue("@Durum", durum);
            commandGet.Parameters.AddWithValue("@SiparişKodu", m);
            SqlDataAdapter da = new SqlDataAdapter(commandGet);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                SqlCommand commandDelete = new SqlCommand("Delete from Siparişler where SiparişKodu = @m and Durum = @Durum", Sqlİşlemleri.connection);
                commandDelete.Parameters.AddWithValue("@m", m);
                commandDelete.Parameters.AddWithValue("@Durum", durum);
                Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                commandDelete.ExecuteNonQuery();
                RefreshPage();
            }
            else
            {
                MessageBox.Show("Siparişi silmek için iptal etmelisiniz");
            }                                            
        }
    }
}
