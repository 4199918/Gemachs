using System;
using System.Collections.Generic;

namespace Backend_webapi.Models
{
    public class ProductsGroup
    {
        //properties
        
        //private static int allProductsGroupsCount = 0;
        private int productsGroupId;
        public int ProductsGroupId
        {
            get { return productsGroupId; }
            set { productsGroupId = value; }
        }
        
        private string productsGroupName;
        public string ProductsGroupName
        {
            get { return productsGroupName; }
            set { productsGroupName = value; }
        }
        
        private string productsGroupDescription;
        public string ProductsGroupDescription
        {
            get { return productsGroupDescription; }
            set { productsGroupDescription = value; }
        }

        private List<ProductProperty> productGroupProductProperties;
        public List<ProductProperty> ProductGroupProductProperties
        {
            get { return productGroupProductProperties; }
            set { productGroupProductProperties = value; }
        }

        private List<Product> productGroupProducts;
        public List<Product> ProductGroupProducts
        {
            get { return productGroupProducts; }
            set { productGroupProducts = value; }
        }
        
        
        //constractors

        // public ProductsGroup()
        // {
        //     ProductsGroupId = ++allProductsGroupsCount;
        // }

        public ProductsGroup() { }
    }
}