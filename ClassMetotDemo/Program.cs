using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] BankaMusteri = new string[] { };
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Hüseyin";
            musteri1.Soyadi= "Kiraz";
            musteri1.Sifre = 1234;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Badem";
            musteri2.Sifre = 5678;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Semih";
            musteri3.Soyadi = "Deniz";
            musteri3.Sifre = 9123;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Hilal";
            musteri4.Soyadi = "Kısa";
            musteri4.Sifre = 1026;

            Musteri[] b = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            Console.WriteLine("-----------Müşteri Listeleme----------");
            foreach (Musteri musteri in b)
            {
                
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Sifre);
                Console.WriteLine("Müşteri Listelendi");
            }

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("--------Müşteri Ekleme-------");
            musteriManager.Ekle(musteri1);
            Console.WriteLine("--------Müşteri Ekleme-------");
            musteriManager.Ekle(musteri2);
            Console.WriteLine("--------Müşteri Ekleme-------");
            musteriManager.Ekle(musteri3);
            Console.WriteLine("--------Müşteri Ekleme-------");
            musteriManager.Ekle(musteri4);




        }

    }
}
