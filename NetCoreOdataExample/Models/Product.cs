using Microsoft.AspNet.OData.Builder;

namespace NetCoreOdataExample.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal ListPrice { get; set; }
        [Contained]
        public Category Category { get; set; }
    }
}
