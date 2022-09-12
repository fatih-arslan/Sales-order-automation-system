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
    public partial class Kullanıcı_Girişi : Form
    {
        public static Müşteri müşteri = new Müşteri();
        public static string user;
        public Kullanıcı_Girişi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxKa.Text != String.Empty && textBoxŞifre.Text != String.Empty)
            {                
                SqlCommand commandlog = new SqlCommand("Select * from Musteriler where KullanıcıAdı = @KullanıcıAdı and Şifre = @Şifre", Sqlİşlemleri.connection);
                commandlog.Parameters.AddWithValue("@KullanıcıAdı", textBoxKa.Text);                
                commandlog.Parameters.AddWithValue("@Şifre", textBoxŞifre.Text);
                SqlDataAdapter da = new SqlDataAdapter(commandlog);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {                    
                    müşteri.KullanıcıAdı = textBoxKa.Text;
                    müşteri.Şifre = textBoxŞifre.Text;
                    müşteri.Ad = dt.Rows[0]["Ad"].ToString();
                    müşteri.Soyad = dt.Rows[0]["Soyad"].ToString();
                    müşteri.Adres = dt.Rows[0]["Adres"].ToString();
                    Kullanıcı_Ekranı ke = new Kullanıcı_Ekranı();
                    ke.StartPosition = FormStartPosition.CenterScreen;
                    ke.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi girin");
            }                   
        }

        private void Kullanıcı_Girişi_Load(object sender, EventArgs e)
        {

        }
    }
}
