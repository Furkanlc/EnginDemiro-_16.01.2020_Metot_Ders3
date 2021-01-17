using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemiroğ_16._01._2020_Metot
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " Müşterisi eklendi");

        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Müşteri silindi");
        }
        public void Listele(Musteri[] musteri)
        {
            foreach (var item in musteri)
            {

                Console.WriteLine(item.Adi + " " + item.Soyadi);
            }
        }
    }
}

