using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_otomasyonu
{
    public class Sipariş
    {        
        public DateTime Tarih { get; set; }
        public SiparişDetayı SiparişDetayı { get; set; }
        public string Durum { get; set; }
        public Ödeme ÖdemeYöntemi { get; set; }
        public int Kod { get; set; }

        public Ödeme Ödeme
        {
            get => default;
            set
            {
            }
        }

        public Müşteri Müşteri1
        {
            get => default;
            set
            {
            }
        }
    }
}
