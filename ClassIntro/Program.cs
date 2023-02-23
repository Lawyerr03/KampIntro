using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Mustafa";
            int yas = 28;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmen = "Mustafa Celik";
            kurs1.IzlenmeOrani = "31";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmen = "Enes";
            kurs2.IzlenmeOrani = "61";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.KursunEgitmen = "Ahmet";
            kurs3.IzlenmeOrani = "69";

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmen { get; set; }
        public string IzlenmeOrani { get; set; }
    }
}




// C# Veritipleri
//C# dilindeki temel veri türleri için tamsayı, kesirli sayı, decimal, char, string ve boolean veri tipleri şeklinde kategoriler kullanılabilir. Aşağıda C# veri tipleri (C# data types) gözükmektedir.
//byte : Uzunluğu 1 byte’tır, 0 ile 255 arasında değer alır.

//sbyte : Uzunluğu 1 byte’tır, -128 ile 127 arasında değer alır.

//short : Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır.

//ushort : Uzunlupu 2 byte’tır, 0 ile 65535 arasında değer alır.

//int : Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.648 arasında değer alır.

//uint : Uzunluğu 4 byte’tır, 0 ile 4.294.967.295 arasında değer alır.

//long : Uzunluğu 8 byte’tır, -1020 ile 1020 arasında değer alır.

//ulong : Uzunluğu 8 byte’tır, 0 ile 2 x 1020 arasında değer alır.

//float : Uzunluğu 4 byte’tır, 1.5 x 10 - 45 ile 3.4 x 1038 arasında değer alır.

//double : Uzunluğu 8 byte’tır, 5.0 x 10 - 324 ile 1.7 x 10308 arasında değer alır.

//decimal : Uzunluğu 12 byte’tır, ±1.0 x 10 - 28 ile ±7.9 x 1028 arasında değer alır.

//char : Uzunluğu 2 byte’tır, Bütün ınicode karakterleri kapsar.

//string : Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır.

//boolean : True – false değer tutan tiptir.

//Burada belirtilen C# tipler arasından programı gidişatına göre işimize yarayanları rahatlıkla kullanabiliriz.


//Ternary Operatörü
//Console.Write("[1-10] arasında sayı giriniz :");
//int sayi = int.Parse(Console.ReadLine());
//string cevap = "";
//cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
//Console.WriteLine(cevap);

// Coalescing Kullanımı
//Console.Write("Lütfen yaşınızı giriniz :");
//string yasiniz = Console.ReadLine();
//string sonuc = "";
//Burada iki operatörü birarada kullanmış olduk 
//Ternary kullanma amaçımız kullanıcı direkt boş geçerse stringlerde boş değer bir karakter olduğudan
//Coalescing de bildiğiniz gibi null değer gelirse varsayılan değeri yazdırır.
//sonuc = (yasiniz == "" ? null : yasiniz) ?? "Boş geçildi.";
//Console.WriteLine("Yaşınız :" + sonuc);