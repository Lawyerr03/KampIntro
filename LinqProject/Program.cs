using System;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName = "Bilgisayar" },
                new Category{CategoryId=2,CategoryName = "Telefon" }


            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId= 1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=10000,UnitsInStock=5 },
                new Product{ProductId = 2,CategoryId= 1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=18000,UnitsInStock=3 },
                new Product{ProductId = 3,CategoryId= 1,ProductName="Hp Laptop",QuantityPerUnit="8 GB Ram",UnitPrice=18000,UnitsInStock=2 },
                new Product{ProductId = 4,CategoryId= 2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=5000,UnitsInStock=15 },
                new Product{ProductId = 5,CategoryId= 2,ProductName="Apple Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=8000,UnitsInStock=0 }


            };
            //Test(products);

            // GetProducts(products);

            //Any --- Bir listede eleman var mı yok mu onu ararız!!
            //AnyTest(products);

            //Find --- Bir ürünün detay bilgisine gitmek için kullanılır!!!
            //FindTest(products);

            //FindAll --- Eşleşen elemanları bulmamıza yarar
            //FinAllTest(products);

            //OrderBy --- Artana göre sırala  && OrderByDescensing --- Düşene göre sırala
            //ThenBy --- Sıralama Yaptırır
            //AscDescTest(products);

            //ClassicLinqTest(products);
            //
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice>5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.CategoryId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine( "{0} --- {1}", productDto.ProductName, productDto.CategoryName);// + ile uğraşmak istemiyorsak " {0} {1}" kullanırız

            }

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);

            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FinAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik--------------------");


            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("Linq---------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products ) 
        {
            List<Product> filteredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProduct.Add(product);
                }

            }

            return filteredProduct;
        }

        static List<Product> GetProductsLinq(List<Product> products) 
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }


    }
    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit  { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }


    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
