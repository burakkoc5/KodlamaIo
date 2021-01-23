using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelFinanceCreditManager = new PersonelFinanceCreditManager();
            //personelFinanceCreditManager.Calculate();
            ICreditManager transportCreditManager = new TransportCreditManager();
            //transportCreditManager.Calculate();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            
            
            ApplicationManager applicationManager = new ApplicationManager();
            
            
            
            applicationManager.Apply(new ArtisanCreditManager(),
                new List<ILoggerService> {new DatabaseLoggerService(),new SmsLoggerService() });

            
            
            List<ICreditManager> credits = new List<ICreditManager>();
            credits.Add(personelFinanceCreditManager);
            credits.Add(transportCreditManager);
            //applicationManager.MakeCreditPreInform(credits);

        }
    }
}
