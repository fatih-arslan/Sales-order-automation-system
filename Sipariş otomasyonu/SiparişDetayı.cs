using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_otomasyonu
{
    public class SiparişDetayı
    {
        public List<Ürün> Ürünler { get; set; }
        public double ToplamTutar { get; set; }
        public double ToplamAğırlık { get; set; }

        public Sipariş Sipariş
        {
            get => default;
            set
            {
            }
        }

        public override string ToString()
        {
            List<string> l = new List<string>();
            foreach(Ürün ürün in Ürünler)
            {
                ürün.Ad = ürün.Ad.Trim();
                l.Add($"{ürün.SeçilenAdet} {ürün.Ad}");

            }
            string s = String.Join(", ", l);
            return s;
        }
    }
}
