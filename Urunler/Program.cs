using System;

namespace Urunler
{
    class Urun
    {

        public string UrunAdi { get; set; }
        public string UrunImage { get; set; }
        public double UrunFiyat { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Upland Artika 2 Kişilik Çadır";
            urun1.UrunImage = "image1";
            urun1.UrunFiyat = 1180.00;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Rockwell Argon Ayakkabı 43 No";
            urun2.UrunImage = "image2";
            urun2.UrunFiyat = 300.00;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Nurgaz Mini Döküm Tava-8 inch";
            urun3.UrunImage = "image3";
            urun3.UrunFiyat = 150.00;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            Console.WriteLine("for ile");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi+" | "+urunler[i].UrunImage+" | "+urunler[i].UrunFiyat+" TL");
            }

            Console.WriteLine("foreach ile");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " | " + urun.UrunImage + " | " + urun.UrunFiyat+" TL");
            }

            Console.WriteLine("while ile");
            

            int sayi=0;

            while (sayi < urunler.Length)
            {
                Console.WriteLine(urunler[sayi].UrunAdi + " | " + urunler[sayi].UrunImage + " | " + urunler[sayi].UrunFiyat+" TL ");
                sayi++;
            }
            
            Console.ReadLine();
        }
    }
}
