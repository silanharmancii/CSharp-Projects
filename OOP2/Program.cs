using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual(); //gerçek

            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Silan";
            customer1.LastName = "HArmanci";
            customer1.TcNo = "12345678909";

            Coorporate customer2 = new Coorporate(); //tüzel
            customer2.Id = 1;
            customer2.CustomerNo = "12345";
            customer2.CompanyName = "Xyz";
            customer2.TaxNo = "12345664327";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            //new : referans no


        }
    }
}
