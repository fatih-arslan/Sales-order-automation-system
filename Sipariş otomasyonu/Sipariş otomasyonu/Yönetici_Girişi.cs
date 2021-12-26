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
    public partial class Yönetici_Girişi : Form
    {
        public Yönetici_Girişi()
        {
            InitializeComponent();
        }

        private void buttonGiriş_Click(object sender, EventArgs e)
        {
            if(textBoxKa.Text != String.Empty && textBoxŞifre.Text != string.Empty)
            {
                SqlCommand commandlog = new SqlCommand("Select * from Yöneticiler where KullanıcıAdı = @KullanıcıAdı and Şifre = @Şifre", Sqlİşlemleri.connection);
                commandlog.Parameters.AddWithValue("@KullanıcıAdı", textBoxKa.Text);
                commandlog.Parameters.AddWithValue("@Şifre", textBoxŞifre.Text);
                Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                SqlDataAdapter da = new SqlDataAdapter(commandlog);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    KontrolPaneli kp = new KontrolPaneli();
                    kp.Show();
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
    }
}
