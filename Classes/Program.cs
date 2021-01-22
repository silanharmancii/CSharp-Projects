using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Şilan";
            customer1.LastName = "Harmancı";

            Customer customer2 = new Customer
            {
                Id = 2, FirstName="Derin", LastName="Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);


        }
    }
}
