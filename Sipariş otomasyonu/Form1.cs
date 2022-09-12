using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipariş_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 720;
            this.Width = 1200;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            Kullanıcı_Kaydı kk = new Kullanıcı_Kaydı();
            kk.MdiParent = this;
            kk.StartPosition = FormStartPosition.CenterScreen;
            kk.Show();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            Kullanıcı_Girişi kg = new Kullanıcı_Girişi();
            kg.MdiParent = this;
            kg.StartPosition = FormStartPosition.CenterScreen;
            kg.Show();
        }

        private void buttonKontrol_Click(object sender, EventArgs e)
        {
            Yönetici_Girişi yg = new Yönetici_Girişi();
            yg.MdiParent = this;
            yg.StartPosition = FormStartPosition.CenterScreen;
            yg.Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
