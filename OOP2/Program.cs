using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yunus Emre Yılmaz
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.CustomerName = "Yunus Emre";
            customer1.CustomerLastName = "Yılmaz";
            customer1.IdentityNumber = "12312312";


            //kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "435345";
            customer2.CompanyName = "kodlama.io";
            customer2.TaxNumber = "3218974738";




            //Individual Customer - Corporate Customer
            //SOLID
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }


    }
}
