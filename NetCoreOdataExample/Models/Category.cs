using Microsoft.AspNet.OData.Builder;
using System.Collections.Generic;

namespace NetCoreOdataExample.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        [Contained]
        public IList<Product> Products { get; set; }
    }
}
