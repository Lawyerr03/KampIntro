using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            // bu tip verileri arraylerde (dizi) tutarız

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , "Programlamaya başlangıç için temel kurs" , "Java" , "C++"};


            for (int i = 0; i < kurslar.Length; i++) // dinamikleştirmek için .length ekliyoruz bu da bize sonsuz döngü sağlıyor
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar) // dizi temelli yapıları tek tek dönmeye yarıyor (kursları dolaş) dizileri daha kolay dolaşmak için kullanılır
            {
                Console.WriteLine(kurs);
            }



           // for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine(i);
            }
            
           // for (int i = 1; i <= 10; i=i+2) // veyahut i+=2
            {
               // Console.WriteLine(i);
            }


        }
    }

}




   