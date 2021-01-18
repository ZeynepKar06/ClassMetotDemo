using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri { };
            Musteri1.Adi = "Zeynep";
            Musteri1.Soyadi = "KARAKUŞ";
            Musteri1.TelNo = 0555555555;

            Musteri Musteri2 = new Musteri { };
            Musteri2.Adi = "Ömer";
            Musteri2.Soyadi = "TAŞ";
            Musteri2.TelNo = 0532111111;


            Musteri Musteri3 = new Musteri { };
            Musteri3.Adi = "Esra";
            Musteri3.Soyadi = "SU";
            Musteri3.TelNo = 0555222222;

            Musteri[] Musteriler = new Musteri[] {Musteri1,Musteri2 };

            foreach (Musteri musteri in Musteriler)
            {
                Console.WriteLine("Müşteri Adı : "+ musteri.Adi);
                Console.WriteLine("Müşteri Soyadı : "+musteri.Soyadi);
                Console.WriteLine("Müşteri Tel No : "+musteri.TelNo);
                Console.WriteLine("-----------------------------");
            }

            MusteriMeneger musteriMeneger = new MusteriMeneger();
            musteriMeneger.Ekle(Musteri3);

            MusteriMeneger musteriMeneger2 = new MusteriMeneger();
            musteriMeneger2.Sil(Musteri3);

        }
    }
}
