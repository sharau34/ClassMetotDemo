using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri{musteriId = 1, musteriTcNo = 123456, musteriDogumTarihi = 2000, musteriAdi = "Yusuf", musteriSoyadi = "Çırak"};
            Musteri musteri2 = new Musteri { musteriId = 2, musteriTcNo = 234567, musteriDogumTarihi = 2003, musteriAdi = "Rabia", musteriSoyadi = "Nur" };
            Musteri musteri3 = new Musteri { musteriId = 3, musteriTcNo = 345678, musteriDogumTarihi = 2001, musteriAdi = "Mert", musteriSoyadi = "Korkmaz" };

            Console.WriteLine("");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("Belirttiğiniz müşteriler sisteme eklenmiştir.");
            
            Console.WriteLine("");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Listele(musteriler);

            Console.WriteLine("");

            Console.WriteLine("Müşteri silinme işlemi tamamlandı.");
            musteriManager.Sil(musteri1);







        }
    }
}
