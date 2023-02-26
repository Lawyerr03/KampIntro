using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mustafa Çelik
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id= 1;
            musteri1.MusteriNo = "98765";
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "ÇELİK";
            musteri1.TcNo = "123456789";

            // ÇELİK HUKUK BÜROSU

            TuzelMusteri musteri2 = new TuzelMusteri(); 
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "ÇELİK HUKUK BÜROSU";
            musteri2.VergiNo = "7456321";


            // Gerçek Müşteri - Tüzel Müşteri (Birbirinin yerine asla kullanılmaz sırf benziyorlar diye ))
            // SOLID
            
            Musteri musteri3 = new GercekMusteri(); // new bellekteki referans numarası
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



        }
    }
}
