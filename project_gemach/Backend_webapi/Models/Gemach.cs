using System;
using System.Collections.Generic;

namespace Backend_webapi.Models
{
    public class Gemach
    {
        //properties

        //private static int allGemachesCount = 0;
        private int gemachId;
        public int GemachId
        {
            get { return gemachId; }
            set { gemachId = value; }
        }
        
        private string gemachName;
        public string GemachName
        {
            get { return gemachName; }
            set { gemachName = value; }
        }
        
        private string gemachDescription;
        public string GemachDescription
        {
            get { return gemachDescription; }
            set { gemachDescription = value; }
        }

        private string gemachPhone;
        public string GemachPhone
        {
            get { return gemachPhone; }
            set { gemachPhone = value; }
        }

        private string gemachAddress;
        public string GemachAddress
        {
            get { return gemachAddress; }
            set { gemachAddress = value; }
        }

        private string gemachEmail;
        public string GemachEmail
        {
            get { return gemachEmail; }
            set { gemachEmail = value; }
        }

        private List<GemachManager> gemachManagers;
        public List<GemachManager> GemachManagers
        {
            get { return gemachManagers; }
            set { gemachManagers = value; }
        }

        private List<Customer> gemachCustomers;
        public List<Customer> GemachCustomers
        {
            get { return gemachCustomers; }
            set { gemachCustomers = value; }
        }

        private List<ProductsGroup> gemachProductsGroups;
        public List<ProductsGroup> GemachProductsGroups
        {
            get { return gemachProductsGroups; }
            set { gemachProductsGroups = value; }
        }
        

        
        
        //constractors
        
        // public Gemach()
        // {
        //     GemachId = ++allGemachesCount;
        // }

        public Gemach() { }
    }
}