using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1= sayi2;
            sayi2 = 65;
            //sayi1 ?? ----> 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] -----> 999



            //int, decimol, float, double, bool(0-1) === değer tip
            //array ([]), class, interpace == referans tip

            //stack (sayi1=10, sayi2 =30) -----------    heap (new = yeni bir adres ekle demek)

            //satack 101/(sayilar1) ----------> heap 101/[10,20,30]
            //       102/(sayilar2) ----------> heap 102/[100,200,300]
            //sayilar1 = sayilar2; sayılar1 in refarans numarası = sayılar2 nin refarans numarası


            //BU OLAY SÜRDÜRÜLEBİLİRLİK İÇİN ÖNEMLİ !!!! BİR GÜNCELLEME BİR YENİLEME GELDİĞİNDE BU OLAYI KULLANICAZ!!!!!
        }
    }
}