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
    public partial class KullanıcıSiparişEkranı : Form
    {
        public KullanıcıSiparişEkranı()
        {
            InitializeComponent();
        }

        private void KullanıcıSiparişEkranı_Load(object sender, EventArgs e)
        {
            string user = Kullanıcı_Girişi.müşteri.KullanıcıAdı;
            SqlCommand commandGet = new SqlCommand("Select SiparişKodu, Tarih, Tutar, Durum, Ağırlık, Ürünler from Siparişler where KullanıcıAdı = @KullanıcıAdı", Sqlİşlemleri.connection);
            Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
            commandGet.Parameters.AddWithValue("@KullanıcıAdı", user);
            SqlDataAdapter da = new SqlDataAdapter(commandGet);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[5].Width = 400;
            if(dt.Rows.Count == 0)
            {
                textBox1.Visible = true;
            }
        }
    }
}
