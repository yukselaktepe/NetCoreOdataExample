using System.Collections.Generic;

namespace NetCoreOdataExample.Models
{
    public class AzonDataSources
    {
        private static AzonDataSources ds = null;
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        private AzonDataSources()
        {
            Categories = new List<Category>();
            Products = new List<Product>();
            this.PrepareData();
        }

        public static AzonDataSources Instance
        {
            get
            {
                if (ds == null)
                {
                    ds = new AzonDataSources();
                }
                return ds;
            }
        }

        public void PrepareData()
        {
            Category kitapCategory = new Category
            {
                CategoryID = 1,
                Name = "Kitap"
            };
            Category elektronikCategory = new Category
            {
                CategoryID = 2,
                Name = "Elektronik"
            };

            kitapCategory.Products = new List<Product>
            {
                new Product{
                    Category=kitapCategory,
                    ListPrice=20,
                    ProductID=1,
                    Title="C# All in One"
                },
                new Product{
                    Category=kitapCategory,
                    ListPrice=8.95M,
                    ProductID=91,
                    Title="Asp.Net Web API Introduction"
                },
                new Product{
                    Category=kitapCategory,
                    ListPrice=12.50M,
                    ProductID=8,
                    Title="Pragmatic Programmer"
                },
                new Product{
                    Category=kitapCategory,
                    ListPrice=5,
                    ProductID=14,
                    Title="The Last Lecture"
                }
            };

            elektronikCategory.Products = new List<Product>
            {
                new Product{
                    Category=elektronikCategory,
                    ListPrice=200,
                    ProductID=28,
                    Title="LG Tablet x10"
                },
                new Product{
                    Category=elektronikCategory,
                    ListPrice=280.95M,
                    ProductID=92,
                    Title="Apple Smart Watch"
                },
                new Product{
                    Category=elektronikCategory,
                    ListPrice=1200M,
                    ProductID=55,
                    Title="Diesel Watch Blue"
                }
            };

            this.Categories.Add(kitapCategory);
            this.Categories.Add(elektronikCategory);
            this.Products.AddRange(kitapCategory.Products);
            this.Products.AddRange(elektronikCategory.Products);
        }
    }
}
