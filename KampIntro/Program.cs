using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemeGirisYapmisMi == true) //eğer
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else // değilse
            {

                Console.WriteLine("Giriş yap Butonu");
            }    


            Console.WriteLine(kategoriEtiketi);
            

        }





    }












}
