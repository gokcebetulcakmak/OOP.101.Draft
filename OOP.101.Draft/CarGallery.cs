using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._101.Draft
{
    internal class CarGallery
    {
        public string Brand { get; set; } //marka
        public string Model { get; set; } // model
        public string MClass { get; set; } // Sınıf
        public int MPover { get; set; } // Motor gücü
        public int MVolume { get; set; } // Motor Hacmi
        public string MSerial { get; set; } // Motor seri no
        public char GasType { get; set; } // Yakıt türü
        public char GearType { get; set; } // Vites Türü
        public string CaseType { get; set; } // Kasa tipi
        public int ProducedYear { get; set; } // Üretildiği yıl
        public string Colour { get; set; } //Renk bilgisi
        public int Price = 100000; // Fiyatı / Default değer atadım.
    

    }
}
