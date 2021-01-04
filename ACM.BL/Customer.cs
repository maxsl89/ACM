using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class Customer
    {
        public Customer()
            //constructor chaining
            // default constructor calls the parametrize consructor with default value
            :this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            // sets AddressList to empty addresslist instead of null 
            AddressList = new List<Address>();
        }

        // composition relationship (has a)
        public List<Address> AddressList { get; set; }

        // when you use the static modifier you declare a member, that member belong to Class itself
        public static int InstanceCount { get; set; }

        private string _lastName;
        public string  LastName
        {
            get
            {
                // any code here
                return _lastName;
            }
            set 
            {
                // any code here
                _lastName = value;
            }
        }

        // if you dont need to manage anything while getting or setting (auto implemented property)
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        // we can set this property, but any code external to this class cannot
        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }


        

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
