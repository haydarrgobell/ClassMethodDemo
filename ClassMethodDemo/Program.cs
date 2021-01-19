using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.ID = 0001;
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Soydan";
            musteri1.Sehir = "Zonguldak";
            musteri1.Tutar = 1500;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 0010;
            musteri2.Ad = "Zeynep";
            musteri2.Soyad = "Güneş";
            musteri2.Sehir = "Ankara";
            musteri2.Tutar = 2000;


            Musteri musteri3 = new Musteri();
            musteri3.ID = 0011;
            musteri3.Ad = "Haydar";
            musteri3.Soyad = "Gündoğan";
            musteri3.Sehir = "Bursa";
            musteri3.Tutar = 4000;

            Musteri[] musteriler = new Musteri[]
            {
                musteri1,musteri2,musteri3
            };

            MusteriManager manager = new MusteriManager();
            manager.MusteriEkle(musteri2);
            
            Console.WriteLine("========================");
            manager.MusteriGuncelle(musteri3);
            Console.WriteLine("========================");
            manager.MusteriSil(musteri1);
            manager.MusteriListele(musteriler);

            Console.Read();
        }
        
        
        
    }
    
}
