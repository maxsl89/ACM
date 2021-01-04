using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks; 

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository(); 
        }
        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // create the instance of the Customer Class
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            // Code that retrieves the defined customer
             
            //Temporary hard  coded values to return
            //a populated customer
            if(customerId == 1)
            {               
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        /// <summary>
        /// Retrieve list of customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            // Code that retrieves the defined customer
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }
    }
}
