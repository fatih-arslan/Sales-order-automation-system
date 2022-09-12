using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_otomasyonu
{
    public class Çek : Ödeme
    {
        public string AdSoyad { get; set; }
        public string Banka { get; set; }
        public long BankaID { get; set; }
    }
}
