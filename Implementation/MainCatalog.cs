using System;
using System.Linq;
using System.Collections.Generic;
using Coffee.Models;

namespace Coffee.Implementation
{
    public class MainCatalog : Models.IAmTheCatalog
    {
        int reservationId = 0; 
        int id =1; 
        public IEnumerable<CoffeeCatalogItem> Items {get;set;}
        public MainCatalog()
        {
            this.Items = BuildProducts(); 
        }

        public IEnumerable<CoffeeCatalogItem> Catalog(string filter)
        {
            return String.IsNullOrEmpty(filter)
                ? Items
                : Items.Where(p=> p.Description.Contains(filter) || p.TastingNotes.Contains(filter) || p.Id.Equals(filter) );
        }

        public IEnumerable<ReservationResponse> ReserveProducts(IEnumerable<Reservation> reservations)
        {
            return reservations.Select(p=> new ReservationResponse()
            {
                Product = p.Product,
                Size   = p.Size,
                Quantity = p.Quantity, 
                ReservationId = reservationId ++
            });
        }

        public IEnumerable<CoffeeCatalogItem> BuildProducts()
        {
            var a = new List<CoffeeCatalogItem>();
            Add(a, "Starbucks Kati Kati Blend, Whole Bean","The flavors of Africa meet the lush days of summer. It hits you like that first summer breeze. Crisp and smooth with the taste of a new season ripe with possibilities. Kati kati means “between” in Swahili, and this blend strikes the delicate balance between vibrant tangy notes from Kenya and the multilayered flavors and aromas of Ethiopian coffees. Our master blenders crafted this coffee as a versatile blend. Enjoy it hot to savor the slight roasting and caramel sweetness. Or you can try it iced to accentuate the floral, citrusy notes during those days of lounging in the shade.");

            Add(a,"Starbucks® Iced Coffee Blend, Whole Bean","When we created this blend for our iced coffee beverages, we started with beans that maintain their unique flavors though a range of temperatures—fruity East African and vibrant Latin American coffees. Then we artfully roasted them to a soft, toasty brown. The result is balanced, caramel smooth and utterly refreshing, whether served straight or with milk and your favorite sweetener.");

            Add(a,"Kenya Boom Boom","Kenya's high altitudes, ideal climate and strong traditions have helped put premium Kenyan coffees like this one among the world's most treasured. And as it did when we introduced it in 1971, Kenya continues to astound our expert tasters and customers alike with flavors not commonly ascribed to coffee: juicy acidity, low wine notes and fruity flavors that intensify as the coffee cools. For this reason, Kenya is an important ingredient in our iced-coffee blends. Enjoy it brewed cold or double strength, then served over ice.");


            return a; 
        }
        private void Add(List<CoffeeCatalogItem> cat, string description, string tastingNotes)
        {
            cat.Add(new CoffeeCatalogItem()
            {
                Id = (id++).ToString(), 
                Description = description, 
                TastingNotes = tastingNotes,
                PricingData = new List<Pricing>()
                {
                    new Pricing(){Cost = 9.99,Size = "8 oz", InStock = 101 },
                    new Pricing(){Cost = 29.99,Size = "16 oz", InStock = 101 + id++ },
                }
            });
        }
    }
}