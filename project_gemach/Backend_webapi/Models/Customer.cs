using System;

namespace Backend_webapi.Models
{
    public class Customer
    {

        //properties
        
        private static int allCustomersCount = 0;
        private int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        
        private string customerLastName;
        public string CustomerLastName
        {
            get { return customerLastName; }
            set { customerLastName = value; }
        }
        
        private string customerfirstName;
        public string CustomerFirstName
        {
            get { return customerfirstName; }
            set { customerfirstName = value; }
        }
        
        private string customerIDcard;
        public string CustomerIDcard
        {
            get { return customerIDcard; }
            set { customerIDcard = value; }
        }

        private LendingCart customerLendingCart;
        public LendingCart CustomerLendingCart
        {
            get { return customerLendingCart; }
            set { customerLendingCart = value; }
        }
        


        //constractors

        public Customer()
        {
            CustomerId = ++allCustomersCount;
        }

        //public Customer() { }
    }
}