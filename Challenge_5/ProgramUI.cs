using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class ProgramUI
    {
        CustomerRepo _customerRepo = new CustomerRepo();

        public void Run()
        {
            Customer dustin = new Customer("Dustin", "Cummings", CustomerType.Potential, "We are currently having a 10% discount on new client","dc@yahoo.com");
            Customer allie = new Customer("Allie", "Sweeney", CustomerType.Past, "Its been a long time since we have heard from you. Please consider us again.","as@yahoo.com");

            _customerRepo.AddCustomer(dustin);
            _customerRepo.AddCustomer(allie);

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do:\n\t" +
                    "1. Add customer info\n\t" +
                    "2. View list of customers\n\t" +
                    "3. Update customer info\n\t" +
                    "4. Delete customer info\n\t" +
                    "5. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: //Add Customer
                        AddCustomerInfo();
                        break;
                    case 2: //View List
                        ShowCustomerList();
                        break;
                    case 3://Update Customer info
                        UpdateCustomerInfo();
                        break;
                    case 4://Delete 
                        RemoveCustomerFromList();
                        break;
                    case 5://Exit
                        isRunning = false;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Choose a valid option!!");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void AddCustomerInfo()
        {
            Customer customer = new Customer();
            Console.Clear();
            Console.WriteLine("What is customer's first name?");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine("What is customer's last name?");
            customer.LastName = Console.ReadLine();
            Console.WriteLine("What is this customer's email address?");
            customer.EmailAddress = Console.ReadLine();
            Console.WriteLine("Is this a Past, Present, or Potential customer");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Past":
                    customer.Type = CustomerType.Past;
                    customer.Email = "We are currently having a 10 % discount on new client";
                    break;
                case "Present":
                    customer.Type = CustomerType.Present;
                    customer.Email = "Thank for being a loyal customer. We will be giving you a 15% discount for the next 2 months.";
                    break;
                case "Potential":
                    customer.Type = CustomerType.Potential;
                    customer.Email = "Its been a long time since we have heard from you.Please consider us again.";
                    break;
            }
            _customerRepo.AddCustomer(customer);
        }
        public void ShowCustomerList()
        {
            Console.Clear();
            List<Customer> customersList = _customerRepo.ShowCustomerList();

            Console.WriteLine("FirstName\t LastName\t Status\t Email");
            foreach (Customer customer in customersList)
            {
                Console.WriteLine($"{customer.FirstName:5}\t{customer.LastName:5}\t{customer.Type:5}\t{customer.Email}");
            }
            Console.ReadLine();
        }
        private void RemoveCustomerFromList()
        {
            List<Customer> customerList = _customerRepo.ShowCustomerList();

            Console.WriteLine("\nPlease type in the email address of the customer that you would like removed.");
            foreach (Customer customer in customerList)
            {
                Console.WriteLine($"{customer.FirstName}\t {customer.LastName}\t{customer.EmailAddress}");

            }
            var removedItem = Console.ReadLine();
            foreach (Customer customer in customerList)
            {
                if (removedItem == customer.EmailAddress)
                {
                    _customerRepo.DeleteCustomer(customer);
                    break;
                }
            }
        }
        private void UpdateCustomerInfo()
        {
            List<Customer> customerList = _customerRepo.ShowCustomerList();
            //Customer newCustomerType = new Customer();
            Console.Clear();
            Console.WriteLine("Which customer would you like to update? Please type in their email address.");
            foreach(Customer customer in customerList)
            {
                Console.WriteLine($"{customer.FirstName}\t{customer.LastName}\t{customer.EmailAddress}\t{customer.Type}");
            }
            var updateCustomer = Console.ReadLine();
            foreach (Customer customer in customerList)
            {
                if (updateCustomer == customer.EmailAddress)
                {
                    _customerRepo.DeleteCustomer(customer);
                    break;
                }
            }
            {
                Customer customer = new Customer();
                Console.Clear();
                Console.WriteLine("What is customer's first name?");
                customer.FirstName = Console.ReadLine();
                Console.WriteLine("What is customer's last name?");
                customer.LastName = Console.ReadLine();
                Console.WriteLine("What is this customer's email address?");
                customer.EmailAddress = Console.ReadLine();
                Console.WriteLine("Is this a Past, Present, or Potential customer");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Past":
                        customer.Type = CustomerType.Past;
                        customer.Email = "We are currently having a 10 % discount on new client";
                        break;
                    case "Present":
                        customer.Type = CustomerType.Present;
                        customer.Email = "Thank for being a loyal customer. We will be giving you a 15% discount for the next 2 months.";
                        break;
                    case "Potential":
                        customer.Type = CustomerType.Potential;
                        customer.Email = "Its been a long time since we have heard from you.Please consider us again.";
                        break;
                }
                _customerRepo.AddCustomer(customer);
            }
            //Console.WriteLine("Please type in the new customer type? Past, Present, or Potential");
            //string input = Console.ReadLine();


            //foreach(Customer customer in customerList)
            //{
            //    if(customer.EmailAddress == updateCustomer)
            // {
            //switch (input)
            //{
            //    case "Past":
            //        newCustomerType.Type = CustomerType.Past;
            //        break;
            //    case "Present":
            //        newCustomerType.Type = CustomerType.Present;
            //        break;
            //    case "Potential":
            //        newCustomerType.Type = CustomerType.Potential;
            //        break;
            //}
            //        updateCustomer.Replace($"{customer.Type}",$"{input}");
            //} 
            //}
            // }

        }
    }
}
