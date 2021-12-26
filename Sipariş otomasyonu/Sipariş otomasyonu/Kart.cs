using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_otomasyonu
{
    class Kart : Ödeme
    {
        public string AdSoyad { get; set; }
        public long KartNumarası { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public int GüvenlikKodu { get; set; }
    }
}
