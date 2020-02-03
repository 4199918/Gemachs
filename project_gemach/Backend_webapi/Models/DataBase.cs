using System.Collections.Generic;
using System;

namespace Backend_webapi.Models
{
    public class DataBase
    {

        public List<Gemach> gemaches = new List<Gemach>()
        {
            new Gemach() { 
                GemachId = 100, 
                GemachName = "תפארת נתן יוסף", 
                GemachDescription = "גמ\"ח גמרות מבוארות - שוטנשטיין לעזרה בלימוד הגמרא.", 
                GemachPhone = "0521111111",
                GemachAddress = "אביי 1 אשדוד",
                GemachEmail = "anonimy@gmail.com",
                GemachManagers = new List<GemachManager>()
                { 
                    new GemachManager() 
                    { 
                        GemachManagerLastName = "לב", 
                        GemachManagerFirstName = "אהרון",
                        GemachManagerIDcard = "123456789"
                    }, 
                    new GemachManager() 
                    { 
                        GemachManagerLastName = "גוטליב", 
                        GemachManagerFirstName = "רחל",
                        GemachManagerIDcard = "234567891"
                    } 
                },
                GemachCustomers = new List<Customer>()
                {
                    new Customer() 
                    {
                        CustomerLastName = "ישראלוביץ'",
                        CustomerFirstName = "משה",
                        CustomerIDcard = "951623847",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "גרינבוים",
                        CustomerFirstName = "דוד ישעיהו",
                        CustomerIDcard = "111111111",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "שינקמן",
                        CustomerFirstName = "חנניה מיכאל",
                        CustomerIDcard = "333333333",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "חזן",
                        CustomerFirstName = "רונן",
                        CustomerIDcard = "555555555",
                        CustomerLendingCart = new LendingCart()
                    }
                },
                GemachProductsGroups = new List<ProductsGroup>()
                {
                    new ProductsGroup() 
                    {
                        ProductsGroupId = 1,
                        ProductsGroupName = "גמרות שוטנשטיין",
                        ProductsGroupDescription = "גמרות מבוארות שוטנשטיין",
                        ProductGroupProducts = new List<Product>()
                        {
                            new Product() 
                            {
                                ProductId = 1000,
                                ProductName = "חלק א'",
                                ProductDescription = "מסכת ברכות",
                                ProductPrice = 10,
                                ProductCount = 10
                            },
                            new Product() 
                            {
                                ProductId = 1001,
                                ProductName = "חלק ב'",
                                ProductDescription = "מסכת מכות",
                                ProductPrice = 10,
                                ProductCount = 10
                            },
                            new Product() 
                            {
                                ProductId = 1002,
                                ProductName = "חלק ג'",
                                ProductDescription = "מסכת עירובין",
                                ProductPrice = 10,
                                ProductCount = 10
                            }
                        }
                    }
                }
            },
            
            new Gemach() { 
                GemachId = 101, 
                GemachName = "חמדת יצחק", 
                GemachDescription = "גמ\"ח חומשים.", 
                GemachPhone = "0522222222",
                GemachAddress = "רבא 23/4 אשדוד",
                GemachEmail = "anonimy2@gmail.com",
                GemachManagers = new List<GemachManager>()
                { 
                    new GemachManager() 
                    { 
                        GemachManagerLastName = "מרקוביץ'", 
                        GemachManagerFirstName = "אהרון גדליה",
                        GemachManagerIDcard = "345678912"
                    } 
                },
                GemachCustomers = new List<Customer>()
                {
                    new Customer() 
                    {
                        CustomerLastName = "מילשטיין",
                        CustomerFirstName = "משה",
                        CustomerIDcard = "951623847",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "גרינבוים",
                        CustomerFirstName = "דוד ישעיהו",
                        CustomerIDcard = "111111111",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "לזנובסקי",
                        CustomerFirstName = "שאול דב",
                        CustomerIDcard = "333333333",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "חזן",
                        CustomerFirstName = "חנה יוכבד",
                        CustomerIDcard = "555555555",
                        CustomerLendingCart = new LendingCart()
                    }
                },
                GemachProductsGroups = new List<ProductsGroup>()
                {
                    new ProductsGroup() 
                    {
                        ProductsGroupId = 1,
                        ProductsGroupName = "חומשים",
                        ProductsGroupDescription = "חומשים במגוון הוצאות, מהדורות וכולי.",
                        ProductGroupProducts = new List<Product>()
                        {
                            new Product() 
                            {
                                ProductId = 1000,
                                ProductName = "חלק א'",
                                ProductDescription = "מסכת ברכות",
                                ProductPrice = 10,
                                ProductCount = 10
                            },
                            new Product() 
                            {
                                ProductId = 1001,
                                ProductName = "חלק ב'",
                                ProductDescription = "מסכת מכות",
                                ProductPrice = 10,
                                ProductCount = 10
                            }
                        }
                    }
                }
            },
            
            new Gemach() { 
                GemachId = 102, 
                GemachName = "עזר ליולדת", 
                GemachDescription = "גמ\"ח מוצרי תינוקות.",
                GemachPhone = "0523333333",
                GemachAddress = "הדודאים 1 ערד",
                GemachEmail = "anonimy3@gmail.com",
                GemachManagers = new List<GemachManager>()
                { 
                    new GemachManager() 
                    {
                         GemachManagerLastName = "וידיסלבסקי", 
                         GemachManagerFirstName = "חיים משה",
                         GemachManagerIDcard = "456789123"
                    } 
                },
                GemachCustomers = new List<Customer>()
                {
                    new Customer() 
                    {
                        CustomerLastName = "וידיסלבסקי",
                        CustomerFirstName = "יוסף",
                        CustomerIDcard = "951623847",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "מלר",
                        CustomerFirstName = "יוסף חיים",
                        CustomerIDcard = "111111111",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "זוננשטיין",
                        CustomerFirstName = "גבריאל",
                        CustomerIDcard = "333333333",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "ספיר",
                        CustomerFirstName = "שירה",
                        CustomerIDcard = "555555555",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "מיכשווילי",
                        CustomerFirstName = "נעמה נעה",
                        CustomerIDcard = "555555555",
                        CustomerLendingCart = new LendingCart()
                    }
                },
                GemachProductsGroups = new List<ProductsGroup>()
                {
                    new ProductsGroup() 
                    {
                        ProductsGroupId = 1,
                        ProductsGroupName = "גמרות שוטנשטיין",
                        ProductsGroupDescription = "גמרות מבוארות שוטנשטיין",
                        ProductGroupProducts = new List<Product>()
                        {
                            new Product() 
                            {
                                ProductId = 1000,
                                ProductName = "חלק א'",
                                ProductDescription = "מסכת ברכות",
                                ProductPrice = 10,
                                ProductCount = 10
                            },
                            new Product() 
                            {
                                ProductId = 1001,
                                ProductName = "חלק ב'",
                                ProductDescription = "מסכת מכות",
                                ProductPrice = 10,
                                ProductCount = 10
                            },
                            new Product() 
                            {
                                ProductId = 1002,
                                ProductName = "חלק ג'",
                                ProductDescription = "מסכת עירובין",
                                ProductPrice = 10,
                                ProductCount = 10
                            }
                        }
                    }
                }
            },
            
            new Gemach() { 
                GemachId = 103,
                GemachName = "וחי אחיך", 
                GemachDescription = "גמ\"ח תרופות.",
                GemachPhone = "0524545454",
                GemachAddress = "הפרחים 10 אשדוד",
                GemachEmail = "anonimy6@gmail.com",
                GemachManagers = new List<GemachManager>()
                { 
                    new GemachManager() 
                    { 
                        GemachManagerLastName = "לב", 
                        GemachManagerFirstName = "מרים",
                        GemachManagerIDcard = "567891234"
                    } 
                },
                GemachCustomers = new List<Customer>()
                {
                    new Customer() 
                    {
                        CustomerLastName = "שפריר",
                        CustomerFirstName = "אלחנן",
                        CustomerIDcard = "951623847",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "גרינבוים",
                        CustomerFirstName = "אלחנן",
                        CustomerIDcard = "111111111",
                        CustomerLendingCart = new LendingCart()
                    },
                    new Customer() 
                    {
                        CustomerLastName = "בוזגלו",
                        CustomerFirstName = "אלנתן",
                        CustomerIDcard = "333333333",
                        CustomerLendingCart = new LendingCart()
                    }
                },
                GemachProductsGroups = new List<ProductsGroup>()
                {
                    new ProductsGroup() 
                    {
                        ProductsGroupId = 1,
                        ProductsGroupName = "גמרות שוטנשטיין",
                        ProductsGroupDescription = "גמרות מבוארות שוטנשטיין",
                        ProductGroupProducts = new List<Product>()
                        {
                            new Product() 
                            {
                                ProductId = 1000,
                                ProductName = "חלק א'",
                                ProductDescription = "מסכת ברכות",
                                ProductPrice = 10,
                                ProductCount = 10
                            },
                            new Product() 
                            {
                                ProductId = 1001,
                                ProductName = "חלק ב'",
                                ProductDescription = "מסכת מכות",
                                ProductPrice = 10,
                                ProductCount = 10
                            },
                            new Product() 
                            {
                                ProductId = 1002,
                                ProductName = "חלק ג'",
                                ProductDescription = "מסכת עירובין",
                                ProductPrice = 10,
                                ProductCount = 10
                            }
                        }
                    }
                }
            }
        };        //methods

    }

}