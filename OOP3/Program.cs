using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager pfcManager = new PersonalFinanceCreditManager(); // interface'ler de o interface'i implement eden classın referans numarasını alabiliyor.
            //pfcManager.Calculation();

            ICreditManager vcManager = new VehicleCreditManager();
           // vcManager.Calculation();

            ICreditManager mcManager = new MortgageCreditManager();
            // mcManager.Calculation();

            ILoggerService databaseLoggerService = new DatasaseLoggerService();
            ILoggerService fileLoggerSerivice = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(pfcManager, databaseLoggerService);
            //applicationManager.MakeApplication(vcManager);
            //applicationManager.MakeApplication(mcManager);

            List<ICreditManager> credits = new List<ICreditManager>() { pfcManager,vcManager};
            //applicationManager.CreditPreInformation(credits);
        }
    }
}
