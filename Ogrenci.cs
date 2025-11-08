using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciYonetimSistemi
{
    // Her öğrenci bir nesne
    internal class Ogrenci
    {
        // Property'ler → veri kapsülleme Encapsulation (veriyi korur)
        public string Ad {  get; set; }
        public string Soyad { get; set; }
        public int Numara { get; set; }
        public double NotOrtalaması { get; set; }

        // Constructor → nesne oluşturma sırasında veri atama
        public Ogrenci(string ad, string soyad, int numara, double notOrt )
        {
        Ad = ad;
        Soyad = soyad;
        Numara = numara;
            NotOrtalaması = notOrt;
        }
        // Bilgileri formatlı göster Method
        public string bilgiGoster()
        {
            return "${Ad} { Soyad}-No:{Numara }-Ortalama :{ NotOrtalaması}";
        }
    }
}
