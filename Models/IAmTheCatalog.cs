using System;
using System.Collections.Generic;

namespace Coffee.Models
{
    public interface IAmTheCatalog
    {
        IEnumerable<CoffeeCatalogItem> Catalog(string filter);
        IEnumerable<ReservationResponse> ReserveProducts(IEnumerable<Reservation> reservations);
    }
}

