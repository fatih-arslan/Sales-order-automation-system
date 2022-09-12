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
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }
        public void RefreshPage()
        {
            SqlCommand commandList = new SqlCommand("Select * from Musteriler", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }
        
        private void buttonSil_Click(object sender, EventArgs e)
        {
            string m = dataGridView1.CurrentRow.Cells["KullanıcıAdı"].Value.ToString();
            SqlCommand commandDelete = new SqlCommand("Delete from Musteriler where KullanıcıAdı = @m",Sqlİşlemleri.connection);
            commandDelete.Parameters.AddWithValue("@m",m);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            commandDelete.ExecuteNonQuery();
            RefreshPage();
        }
    }
}
