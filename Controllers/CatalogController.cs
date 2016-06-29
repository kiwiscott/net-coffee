using System.Collections.Generic;
using Coffee.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Controllers
{
    [Route("api/catalog")]
    public class CatalogController : Controller
    {
        IAmTheCatalog _catalog;
        public CatalogController(IAmTheCatalog catalog)
        {
            _catalog = catalog;

        }
        // GET api/values
        [HttpGet]
        public IEnumerable<CoffeeCatalogItem> Get()
        {
            return _catalog.Catalog(null);
        }

        // GET api/values/5
        [HttpGet("{query}")]
        public IEnumerable<CoffeeCatalogItem> Get(string query)
        {
           return _catalog.Catalog(query);
        }
    }
}
