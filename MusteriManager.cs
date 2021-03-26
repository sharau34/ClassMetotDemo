using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Merhaba {0} {1}, bankamıza hoşgeldiniz!", musteri.musteriAdi,musteri.musteriSoyadi);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşterinin bankamızdaki ID'si : " + musteri.musteriId);
                Console.WriteLine("Müşteri TC Kimlik Numarası : " + musteri.musteriTcNo);
                Console.WriteLine("Müşteri {0} {1}",musteri.musteriAdi,musteri.musteriSoyadi);
                Console.WriteLine("Müşteri doğum tarihi : "+musteri.musteriDogumTarihi);
                Console.WriteLine("--------------------");
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} kimlik no'lu {1} {2} adlı müşterinin hesap bilgileri silinmiş olup {3} no'lu ID'si veri kasasında saklanacaktır.", musteri.musteriTcNo, musteri.musteriAdi, musteri.musteriSoyadi, musteri.musteriId);
        }



    }
}
