using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Backend_webapi.Models;
using Microsoft.AspNetCore.Cors;
//using System.Web.Http.Cors;

namespace Backend_webapi.Controllers
{   
    [EnableCors("AllowAll")]
    //[EnableCors(origins: "https://localhost:4200", headers: "*", methods: "*")]
    [Produces("application/json")]
    [Route("api/gemaches")]
    [ApiController]
    public class GemachesController : ControllerBase
    {

        List<Gemach> gemaches = new DataBase().gemaches;


        //Get gemaches
        [HttpGet]
        public IEnumerable<Gemach> GetGemaches()
        {
            return gemaches;
        }


        //Get gemach by id
        [HttpGet("gemachid/{gemachid}")]
        public IEnumerable<Gemach> GetGemachByGemachId(int gemachid)
        {
            IEnumerable<Gemach> retVal =
                from g in gemaches 
                where g.GemachId.Equals(gemachid) 
                select g;

            return retVal;

        }


        //Get gemach customers
        [HttpGet("gemachid/{gemachid}/customers")]
        public IEnumerable<Customer> GetGemachCustomersByGemachId(int gemachid)
        {
            Gemach gemach = gemaches.Find( g => g.GemachId == gemachid );
            IEnumerable<Customer> retVal = gemach.GemachCustomers;

            return retVal;
        }  

    
        //Get gemach customer by id
        [HttpGet("gemachid/{gemachid}/customers/customerid/{customerid}")]
        public Customer GetGemachCustomerByGemachIdAndCustomerId(int gemachid, int customerid)
        {
            Gemach gemach = gemaches.Find( g => g.GemachId == gemachid );
            Customer retVal = gemach.GemachCustomers.Find( gc => gc.CustomerId == customerid );

            return retVal;
        }  


        //Get gemach managers
        [HttpGet("gemachid/{gemachid}/managers")]
        public IEnumerable<GemachManager> GetGemachManagersByGemachId(int gemachid)
        {
            Gemach gemach = gemaches.Find( g => g.GemachId == gemachid );
            IEnumerable<GemachManager> retVal = gemach.GemachManagers;

            return retVal;
        }       


        //Get gemach manager by id
        [HttpGet("gemachid/{gemachid}/managers/managerid/{managerid}")]
        public GemachManager GetGemachManagerByGemachIdAndManagerId(int gemachid, int managerid)
        {
            Gemach gemach = gemaches.Find( g => g.GemachId == gemachid );
            GemachManager retVal = gemach.GemachManagers.Find( gc => gc.GemachManagerId == managerid );

            return retVal;
        }  


        //Get gemach products groups
        [HttpGet("gemachid/{gemachid}/productsgroups")]
        public IEnumerable<ProductsGroup> GetGemachProductsGroupsByGemachId(int gemachid)
        {
            Gemach gemach = gemaches.Find( g => g.GemachId == gemachid );
            IEnumerable<ProductsGroup> retVal = gemach.GemachProductsGroups;

            return retVal;
        }       


        //Get gemach products group by id
        [HttpGet("gemachid/{gemachid}/productsgroups/productsgroupid/{productsgroupid}")]
        public ProductsGroup GetGemachProductsGroupByGemachIdAndProductsGroupId(int gemachid, int productsgroupid)
        {
            Gemach gemach = gemaches.Find( g => g.GemachId == gemachid );
            ProductsGroup retVal = gemach.GemachProductsGroups.Find( gpg => gpg.ProductsGroupId == productsgroupid );

            return retVal;
        }  

        
        //Get gemach products group products
        [HttpGet("gemachid/{gemachid}/productsgroups/productsgroupid/{productsgroupid}/products")]
        public IEnumerable<Product> GetGemachProductsGroupsProductsByGemachIdAndProductsGroup(int gemachid, int productsgroupid)
        {
            Gemach gemach = gemaches.Find( g => g.GemachId == gemachid );
            ProductsGroup productsGroup = gemach.GemachProductsGroups.Find( gpg => gpg.ProductsGroupId == productsgroupid);
            IEnumerable<Product> retVal = productsGroup.ProductGroupProducts;

            return retVal;
        }       


        //Get gemach products group product by id
        [HttpGet("gemachid/{gemachid}/productsgroups/productsgroupid/{productsgroupid}/products/productid/{productid}")]
        public Product GetGemachProductsGroupProductByGemachIdAndProductsGroupIdAndProductId(int gemachid, int productsgroupid, int productid)
        {
            Gemach gemach = gemaches.Find( g => g.GemachId == gemachid );
            ProductsGroup productsGroup = gemach.GemachProductsGroups.Find( gpg => gpg.ProductsGroupId == productsgroupid);
            Product retVal = productsGroup.ProductGroupProducts.Find( gpgp => gpgp.ProductId == productid );

            return retVal;
        }  

    }
}