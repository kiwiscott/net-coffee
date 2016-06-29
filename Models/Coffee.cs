using System.Collections.Generic; 

namespace Coffee.Models
{
    public class CoffeeCatalogItem
    {
        public string Id { get;  set; }
        public string Description { get;  set; }
        public string TastingNotes { get;  set; }
        public IEnumerable<Pricing> PricingData { get;  set; }
    }
    public class Pricing
    {
        public double Cost { get; set; }
        public string Size {get;set;}

        public int InStock {get;set;}
    }
}