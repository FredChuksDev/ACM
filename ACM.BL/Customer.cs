using Acme.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        //---Default Constructor
        public Customer(): this(0)
        {

        }

        //---Overloaded Constructor
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(FullName))
                    {
                        fullName = ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;

            } }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;

            }
        }

        public object EntityState { get; private set; }



        ////Retrieve Method(It returns one customer)

        //public Customer Retrieve(int customerId)
        //{


        //    return new Customer();
        //}
        ////Retrieve Method(It returns a variety of customers)
        //public List<Customer> Retrieve()
        //{
        //    return new List<Customer>();
        //}


        ////Save Method

        //public bool Save()
        //{
        //    return true;
        //}

        //public string Log ()
        //{
        //    var logString = CustomerId + ": " +
        //                    FullName + "" +
        //                    "Email: " + EmailAddress + " " +
        //                    "Status: " + EntityState.ToString();
        //    return logString;

        //}

        public string Log() =>
            $"{CustomerId}: {FullName} Email:{EmailAddress} Status: {EntityState.ToString()}";


        public override string ToString() => FullName;

        //Validate Method
        public bool Validate()
         {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;


         }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
