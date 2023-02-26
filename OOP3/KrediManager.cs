using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     interface IKrediManager //şablon // okunurluğu arttırmak için interfaceler "I" harfi ile başlar ve bunun interface olduğunu anlarız
    {
        void Hesapla();

        void BiseyYap();
      
    }
}
// interfaceleri birbirinin alternatifi olan ama ama  kod içerikleri farklı olan durumlar için kullanırız.. Örn: krediler --- farklı krediler de hesaplama var ama hepsinin hesaplaması farklı