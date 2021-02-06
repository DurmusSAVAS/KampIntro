using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKredimanager = new TasıtKredimanager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKredisiManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();
           basvuruManager.BasvuruYap(esnafKredisiManager,new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,tasıtKredimanager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
