using System;

namespace Backend_webapi.Models
{
    public class Lending
    {
        //properties
        
        //private static int allLendingsCount = 0;
        private int lendingId;
        public int LendingId
        {
            get { return lendingId; }
            set { lendingId = value; }
        }
        
        
        

        //constractors

        // public Lending()
        // {
        //     LendingId = ++allLendingsCount;
        // }

        public Lending() { }
    }
}