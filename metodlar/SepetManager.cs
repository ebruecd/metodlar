using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! :"+urun.Adi);
            Console.WriteLine("Tebrikler. Sepete Eklendi! :" + urun.Fiyati);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! :" + urunAdi);
        }
    }
}
