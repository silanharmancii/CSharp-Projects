using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeApplication(ICreditManager creditManager,ILoggerService loggerService)
        {
            creditManager.Calculation(); // true
            loggerService.Log();


            //tüm başvurular konut kredisi üzerinden hesaplanır. 
            // false
            //MortgageCreditManager mcManager = new MortgageCreditManager();
            //mcManager.Calculation();
        }

        public void CreditPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculation();
            }
        }
    }
}
