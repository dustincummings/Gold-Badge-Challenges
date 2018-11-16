using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Challenge_5
{
    class CustomerRepo
    {
        List<Customer> _customerList = new List<Customer>();
      
        public void AddCustomer(Customer customer)
        {
            _customerList.Add(customer);
        }
        public void DeleteCustomer(Customer removedCustomer)
        {
            _customerList.Remove(removedCustomer);
        }
        public List<Customer> ShowCustomerList()
        {

            foreach (Customer customer in _customerList)
                {
                    _customerList.Sort((a, b) => string.Compare(a.FirstName, b.FirstName));
                }
                return _customerList;
        }
        public List<Customer> UpdateCustomer()
        {
            
            return 
        }
        


    }
}