using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
           

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.Muzik = "Rock";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Alex";
            musteri2.Soyadi = "De Souza";
            musteri2.Muzik = "Latino";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Zidane";
            musteri3.Soyadi = "Zinedine";
            musteri3.Muzik = "Classic";

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                

                Console.WriteLine(musteri.Adi);
           

                Console.WriteLine(musteri.Soyadi);
                

                Console.WriteLine(musteri.Muzik);

                Console.WriteLine("************");
            }

            MusteriManager musterimanager = new MusteriManager();
            Console.WriteLine("Musteri Ekleme");
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);
            Console.WriteLine("************");

            Console.WriteLine("Musteri Silme");
            musterimanager.Sil(musteri1);
            musterimanager.Sil(musteri2);
            musterimanager.Sil(musteri3);
            Console.WriteLine("************");

            Console.WriteLine("Musteri Listeleme");
            musterimanager.Listeleme(musteri1);
            musterimanager.Listeleme(musteri2);
            musterimanager.Listeleme(musteri3);
            Console.WriteLine("************");



        }
    } 
}
