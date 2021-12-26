using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_otomasyonu
{
    public class Müşteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Şifre { get; set; }
        public string Adres { get; set; }
        public Sipariş Sipariş { get; set; }
        
    }
}
