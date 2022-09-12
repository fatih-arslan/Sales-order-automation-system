using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_otomasyonu
{
    public class Ürün
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public double Ağırlık { get; set; }
        public int SeçilenAdet { get; set; }
        public int Stok { get; set; }

        public SiparişDetayı SiparişDetayı
        {
            get => default;
            set
            {
            }
        }
    }
}
