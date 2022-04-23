using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsumerCreditManager consumerCreditManager = new ConsumerCreditManager();
            //consumerCreditManager.Calculate();


            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            //MortgageManager mortgageManager = new MortgageManager();
            //mortgageManager.Calculate();



            //Console.WriteLine("********************************");



            //ICreditManager consumerCreditManager1 = new ConsumerCreditManager();
            //consumerCreditManager1.Calculate();


            //ICreditManager vehicleCreditManager1 = new VehicleCreditManager();
            //vehicleCreditManager1.Calculate();

            //ICreditManager mortgageManager1 = new MortgageManager();
            //mortgageManager1.Calculate();





            ICreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageManager = new MortgageManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ICreditManager smallBusinessCreditManager = new SmallBusinessCreditManager();
            ILoggerService smsLoggerService = new SmsLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();


            //applicationManager.Apply(smallBusinessCreditManager, new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService() });

            applicationManager.Apply(smallBusinessCreditManager, new List<ILoggerService>() { databaseLoggerService, fileLoggerService , smsLoggerService });

            //applicationManager.Apply(smallBusinessCreditManager, smsLoggerService);
            //applicationManager.Apply(mortgageManager, new DatabaseLoggerService()); // bu şekilde de yazılabilir


            List<ICreditManager> credits = new List<ICreditManager>() {consumerCreditManager,vehicleCreditManager, };
            //applicationManager.CreditPreInformation(credits);











        }
    }
}
