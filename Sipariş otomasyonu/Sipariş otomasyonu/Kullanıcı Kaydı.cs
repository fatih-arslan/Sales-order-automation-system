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
    public partial class Kullanıcı_Kaydı : Form
    {
        public static Müşteri müşteri;
        public Kullanıcı_Kaydı()
        {
            InitializeComponent();
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            if(textBoxAd.Text != String.Empty && textBoxSoyad.Text != String.Empty && 
                textBoxKa.Text != String.Empty && textBoxSifre.Text != String.Empty && textBoxAdres.Text != string.Empty)
            {
                try
                    {                        
                        SqlCommand commandAdd = new SqlCommand("Insert into Musteriler (Ad, Soyad, KullanıcıAdı, Şifre, Adres) " +
                            "values (@Ad, @Soyad, @KullanıcıAdı, @Şifre, @Adres)", Sqlİşlemleri.connection);
                        commandAdd.Parameters.AddWithValue("@Ad", textBoxAd.Text);
                        commandAdd.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
                        commandAdd.Parameters.AddWithValue("@KullanıcıAdı", textBoxKa.Text);
                        commandAdd.Parameters.AddWithValue("@Şifre", textBoxSifre.Text);
                        commandAdd.Parameters.AddWithValue("@Adres", textBoxAdres.Text);
                        Sqlİşlemleri.CheckConnection(Sqlİşlemleri.connection);
                        commandAdd.ExecuteNonQuery();
                        this.Hide();
                        MessageBox.Show("Kayıt tamamlandı");
                    }
                catch (Exception)
                    {
                        MessageBox.Show("Bu kullanıcı adı alınmış, lütfen başka bir kullanıcı adı seçin");
                    }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }            
        }
    }
}
