using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Musteri // claslar ya özellik tutar ya da operasyon tutar  ÖZELLİK PROP LA OLUŞTURULUR!!!!
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }


        //eğer ki bir nesne de bir değeri kullanmak zorunda görünmüyorsan o nesneye ait değilmiş gibi duruyorsa o alan demek ki orada hata yapıyoruz. Soyutlama hatası
    }
}
