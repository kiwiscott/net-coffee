using System;
using System.Linq;
using System.Collections.Generic;
using Coffee.Models;

namespace Coffee.Implementation
{
    public class MainCatalog : Models.IAmTheCatalog
    {
        int reservationId = 0; 
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
            return new List<CoffeeCatalogItem>();
        }
    }
}