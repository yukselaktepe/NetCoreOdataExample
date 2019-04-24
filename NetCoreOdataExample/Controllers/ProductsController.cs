using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using NetCoreOdataExample.Models;

namespace NetCoreOdataExample.Controllers
{
    public class ProductsController
         : ODataController
    {
        [EnableQuery]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(AzonDataSources.Instance.Products.AsQueryable());
        }
    }
}
