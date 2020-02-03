using System;

namespace Backend_webapi.Models
{
    public class LendingCart
    {
        //properties
        
        private static int allLendingCartsCount = 0;
        private int lendingCartId;
        public int LendingCartId
        {
            get { return lendingCartId; }
            set { lendingCartId = value; }
        }
        
        
        

        //constractors

        public LendingCart()
        {
            LendingCartId = ++allLendingCartsCount;
        }

        //public LendingCart() { }
    }
}