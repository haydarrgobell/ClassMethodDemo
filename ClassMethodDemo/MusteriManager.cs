using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
       public void MusteriEkle(Musteri value)
        {
            Console.WriteLine("===Müşteri Eklendi : " + value.Ad +" "+ value.Soyad + "\n" + "Şehir : " + value.Sehir);
        }
        public void MusteriSil(Musteri value)
        {
            Console.WriteLine(value.Ad + " " +value.Soyad+ " İsimli Müşteri Silindi.");
        }
        public void MusteriGuncelle(Musteri value)
        {
            Console.WriteLine(value.ID.ToString() +" Numaralı Müşteri Bilgisi Güncellendi.");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var item in musteriler)
            {
                Console.WriteLine("ID : "+item.ID.ToString());
                Console.WriteLine("Ad : " + item.Ad);
                Console.WriteLine("Soyad : " + item.Soyad);
                Console.WriteLine("Şehir : " + item.Sehir);
                Console.WriteLine("Tutar : " + item.Tutar);
            }
        }
    }
}
