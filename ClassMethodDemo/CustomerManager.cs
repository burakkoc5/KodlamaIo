using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public ArrayList allCustomers { get; set; }

        public void showCustomers(Customer[] customerList)
        {

            foreach (Customer customer in customerList)
            {

                Console.WriteLine("Customer " + customer.id + " is " + customer.firstName+" "+customer.lastName);
            }

        }

        public void addCustomer(Customer customer) 
        {
            
            Console.WriteLine("New customer was added." +" Welcome, " 
                +customer.firstName +" "+ customer.lastName );
            
        }

        public void deleteCustomer(Customer customer)
        {
           
            Console.WriteLine("The customer named " + 
                customer.firstName + " " + customer.lastName  + " was deleted.");


        }


    }
}
