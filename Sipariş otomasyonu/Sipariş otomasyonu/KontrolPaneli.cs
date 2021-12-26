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
    public partial class KontrolPaneli : Form
    {
        public KontrolPaneli()
        {
            InitializeComponent();
        }

        private void buttonMusteri_Click(object sender, EventArgs e)
        {
            MusteriListesi ml = new MusteriListesi();
            ml.Show();
        }

        private void buttonYonetici_Click(object sender, EventArgs e)
        {
            YöneticiListesi yl = new YöneticiListesi();
            yl.Show();
        }

        private void buttonYöneticiEkle_Click(object sender, EventArgs e)
        {
            YöneticiKaydı yk = new YöneticiKaydı();
            yk.Show();
        }

        private void buttonÜrünEkle_Click(object sender, EventArgs e)
        {
            ÜrünEkleme üe = new ÜrünEkleme();
            üe.Show();
        }

        private void buttonÜrünler_Click(object sender, EventArgs e)
        {
            ÜrünListesi üs = new ÜrünListesi();
            üs.Show();
        }

        private void buttonSiparişler_Click(object sender, EventArgs e)
        {
            YöneticiSiparişEkranı yse = new YöneticiSiparişEkranı();
            yse.Show();
        }
    }
}
