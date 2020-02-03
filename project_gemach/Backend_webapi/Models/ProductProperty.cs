using System;
using System.Collections.Generic;

namespace Backend_webapi.Models
{
    public class ProductProperty
    {
        //properties
        
        private static int allProductPropertysCount = 0;
        private int productPropertyId;
        public int ProductPropertyId
        {
            get { return productPropertyId; }
            set { productPropertyId = value; }
        }
        
        private string productPropertyName;
        public string ProductPropertyName
        {
            get { return productPropertyName; }
            set { productPropertyName = value; }
        }
        
        private string productPropertyDescription;
        public string ProductPropertyDescription
        {
            get { return productPropertyDescription; }
            set { productPropertyDescription = value; }
        }
        
        
        //constractors

        public ProductProperty()
        {
            ProductPropertyId = ++allProductPropertysCount;
        }

        //public ProductsGroup() { }
    }
}