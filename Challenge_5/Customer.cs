using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public enum CustomerType {Past =1, Present, Potential}
    class Customer
    {
        public CustomerType Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EmailAddress { get; set; }

        public Customer(string firstName, string lastName, CustomerType type, string email, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Type = type;
            Email = email;
            EmailAddress = emailAddress;
        }

        public Customer()
        {

        }
    }
}
