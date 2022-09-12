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
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
        }
        public void RefreshPage()
        {
            try
            {
                string user = Kullanıcı_Girişi.müşteri.KullanıcıAdı;
                double toplamTutar;
                SqlCommand commandGet = new SqlCommand($"Select * from {user}Sepet", Sqlİşlemleri.connection);
                Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                SqlDataAdapter da = new SqlDataAdapter(commandGet);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;                
                SqlCommand commandCost = new SqlCommand($"Select Sum(Tutar) from {user}Sepet", Sqlİşlemleri.connection);
                Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                toplamTutar = (double)commandCost.ExecuteScalar();               
                textBoxToplamTutar.Text = toplamTutar.ToString()+ "₺";
                                                        
            }
            catch (Exception)
            {
                textBox1.Text = "Sepetiniz boş";
                textBox1.Visible = true;
                buttonÜrünÇıkar.Enabled = false;
                buttonSiparişTamamla.Enabled = false;
            }
        }

        private void Sepet_Load(object sender, EventArgs e)
        {
            RefreshPage();               
        }

        private void buttonÜrünÇıkar_Click(object sender, EventArgs e)
        {
            string ürün = dataGridView1.CurrentRow.Cells["Ürün"].Value.ToString();
            string user = Kullanıcı_Girişi.müşteri.KullanıcıAdı;          
            SqlCommand commandDelete = new SqlCommand($"Delete from {user}Sepet  where Ürün = @Ürün", Sqlİşlemleri.connection);
            commandDelete.Parameters.AddWithValue("@Ürün", ürün);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            commandDelete.ExecuteNonQuery();

            RefreshPage();

        }

        private void buttonSiparişTamamla_Click(object sender, EventArgs e)
        {
            ÖdemeYöntemi öy = new ÖdemeYöntemi();
            öy.Show();
            this.Hide();
        }
    }
}
