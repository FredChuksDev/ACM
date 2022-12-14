using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            //Create the intance of a customer class
            //and pass in the requested Id
            Customer customer = new Customer(customerId);


            //Temporary hard-coded values to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).
                ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            //code that saves the passed in customer

            return true;
        }

    }
}
