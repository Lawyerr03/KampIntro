using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();            
            IKrediManager tasitKrediManager = new TasıtKrediManager();          
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService(); 
            ILoggerService fileLogerService = new FileLoggerService();
            
            BasvuruManager basvuruManager = new BasvuruManager();

            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            basvuruManager.BasvuruYap(konutKrediManager, fileLogerService );
            //basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
