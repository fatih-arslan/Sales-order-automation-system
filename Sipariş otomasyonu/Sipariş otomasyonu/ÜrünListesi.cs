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
    public partial class ÜrünListesi : Form
    {
        public ÜrünListesi()
        {
            InitializeComponent();
        }
        public void RefreshPage()
        {
            SqlCommand commandList = new SqlCommand("Select * from Ürünler", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 250;
        }
        private void ÜrünListesi_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            ÜrünEkleme üe = new ÜrünEkleme();
            üe.Show();
        }

        private void buttonÇıkar_Click(object sender, EventArgs e)
        {
            string m = dataGridView1.CurrentRow.Cells["Ürün"].Value.ToString();
            SqlCommand commandDelete = new SqlCommand("Delete from Ürünler where Ürün = @m", Sqlİşlemleri.connection);
            commandDelete.Parameters.AddWithValue("@m", m);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            commandDelete.ExecuteNonQuery();
            RefreshPage();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            ÜrünGüncelleme üg = new ÜrünGüncelleme();
            üg.Show();
        }
    }
}
