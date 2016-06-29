using Coffee.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Controllers
{
    [Route("api/orders")]
    public class OrderController : Controller
    {
        IProcessOrders _orderProcessor;
        public OrderController(IProcessOrders orderProcessor)
        {
            _orderProcessor = orderProcessor; 

        }
        // GET api/values
        [HttpPost]
        public OrderResponse Create(Order o)
        {
         return _orderProcessor.PlaceOrder(o);
        }

        // GET api/values/5
        [HttpGet("{query}")]
        public Order Get(int orderId)
        {
           return _orderProcessor.Order(orderId);
        }
    }
}
