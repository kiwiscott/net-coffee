using System.Collections.Generic;
using Coffee.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Controllers
{
    [Route("api/reservation")]
    public class ReservationController : Controller
    {
        IAmTheCatalog _catalog;
        public ReservationController(IAmTheCatalog catalog)
        {
            _catalog =catalog;

        }
        // GET api/values
        [HttpPost]
        public IEnumerable<ReservationResponse> Reserve(IEnumerable<Reservation> reservations)
        {
            return _catalog.ReserveProducts(reservations);
        }
    }
}