using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Individual
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Burak";
            customer1.Surname = "Koç";
            customer1.IdentificationNumber = "1234567890";
            

            //Corporate
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54123";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "123456789";

            //SOLID-L

            Customer customer3 = new IndividualCustomer();
            
            Customer customer4 = new CorporateCustomer();


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);

        }
    }
}
