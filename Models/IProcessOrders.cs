using System;
using System.Collections.Generic;

namespace Coffee.Models
{
    public interface IProcessOrders
    {       
        OrderResponse PlaceOrder(Order order);
        Order Order(int orderId);
    }
}
