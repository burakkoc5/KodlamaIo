using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.firstName = "Burak";
            customer1.lastName = "Koç";
            customer1.id = 1;

            Customer customer2 = new Customer();
            customer2.firstName = "Engin";
            customer2.lastName = "Demirog";
            customer2.id = 2;

            Customer customer3 = new Customer();
            customer3.firstName = "Berkay";
            customer3.lastName = "Bilgin";
            customer3.id = 3;

            Customer[] customers = new Customer[] {customer1, customer2, customer3 };

            CustomerManager cm = new CustomerManager();
            cm.addCustomer(customer1);
            cm.addCustomer(customer2);
            cm.addCustomer(customer3);

            cm.showCustomers(customers);

            cm.deleteCustomer(customer1);
        }
    }
}
