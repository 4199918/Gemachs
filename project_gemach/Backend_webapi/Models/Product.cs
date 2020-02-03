using System;

namespace Backend_webapi.Models
{
    public class Product
    {
        //properties
        
        //private static int allProductsCount = 0;
        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        
        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        
        private string productDescription;
        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        private double productPrice;
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        private double productCount;
        public double ProductCount
        {
            get { return productCount; }
            set { productCount = value; }
        }
        
        
        //constractors

        // public Product()
        // {
        //     ProductId = ++allProductCount;
        // }

        public Product() { }
    }
}