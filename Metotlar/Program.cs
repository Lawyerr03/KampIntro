using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2= new Urun();
            urun2.Adi ="Karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };
            
            //type - safe - - tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("-------------Metotlar----------------");
            
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "yeşil elma", 10, 4);
            sepetManager.Ekle2("kayısı", "malatya kayısısı", 15, 8);

            // metot tekrar tekrar aynı şeyi kullanabilme imkanı veriyor
        }
    }
}
 

//Dont repeat yourself - DRY - Clean Code - Best Practice