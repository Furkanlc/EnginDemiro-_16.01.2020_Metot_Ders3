using System;

namespace EnginDemiroğ_16._01._2020_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 18;
            musteri.Adi = "Furkan";
            musteri.Soyadi = "GÜLEÇ";
            musteri.Telefon = 0544;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 68;
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "DENİZHAN";
            musteri2.Telefon = 0554;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 40;
            musteri3.Adi = "Berkay   ";
            musteri3.Soyadi = "GÜLEÇ";
            musteri3.Telefon = 940;

            Musteri[] musteriler = new Musteri[] { musteri,musteri2,musteri3};

            foreach (Musteri musteri1  in  musteriler )
            {
                Console.WriteLine(musteri1.Id);
                Console.WriteLine(musteri1.Adi);
                Console.WriteLine(musteri1.Soyadi);
                Console.WriteLine(musteri1.Telefon);

                Console.WriteLine(" ----------- ");

                

            }
            Console.WriteLine("----Metotlar----");

            MusteriManager sepet = new MusteriManager();

            Console.WriteLine("Müşteri Ekleme");
            sepet.Ekle(musteri);

            Console.WriteLine("Müşteri Silme");
            sepet.Sil(musteri);

            Console.WriteLine("Müşteri Listelem ");
            sepet.Listele(musteriler);


            

        }
    }
}
