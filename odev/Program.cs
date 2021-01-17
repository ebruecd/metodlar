using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "Blender";
            urun1.Fiyati = 200;
            urun1.Stok = 3;

            Product urun2 = new Product();
            urun2.UrunAdi = "Çaycı";
            urun2.Fiyati = 300;
            urun2.Stok = 5;

            Product[] urunler = new Product[] { urun1, urun2 };
            //foreach döngüsü
            foreach (Product urun in urunler)
            {
                Console.WriteLine("Ürün adı : "+ urun.UrunAdi);
                Console.WriteLine("Fiyatı :"+urun.Fiyati);
                Console.WriteLine("Stok Adedi : "+urun.Stok);
                Console.WriteLine("***********************");

            }
            //for döngüsü
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürün adı: "+urunler[i].UrunAdi);
                Console.WriteLine("Fiyatı : "+urunler[i].Fiyati);
                Console.WriteLine("Stok Adedi : "+urunler[i].Stok);
                Console.WriteLine("*************************");

            }

            //while döngüsü
            int d = 0;
            while (d < urunler.Length) 
            {
                Console.WriteLine("Ürün adı: " + urunler[d].UrunAdi);
                Console.WriteLine("Fiyatı : " + urunler[d].Fiyati);
                Console.WriteLine("Stok Adedi : " + urunler[d].Stok);
                Console.WriteLine("*************************");
                d++;
            }


        }
    }
}
