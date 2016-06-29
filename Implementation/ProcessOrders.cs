using System;
using System.Linq;
using System.Collections.Generic;
using Coffee.Models;

namespace Coffee.Implementation
{
    public class ProcessOrders : Models.IProcessOrders
    {
        public List<Order> Orders = new List<Order>(); 

        public OrderResponse PlaceOrder(Order order)
        {
            int orderId = Orders.Count + 100001; 
            order.OrderId = orderId; 
            order.Status = "In-Warehouse"; 

            var trackingId =  Guid.NewGuid().ToString(); 
            order.Tracking = new Tracking(){
                    Shipper = "UPS",
                    Status = "To Pick Up",
                    TrackingIdentifier = trackingId, 
                    UrlToTrack = "http://ponyexpress.com?g=" + trackingId
             };

             Orders.Add(order);

             return new OrderResponse()
             {
                 Id = order.OrderId, 
                 ShipmentEta = DateTime.UtcNow.AddDays(3)
             };
        }

        public Order Order(int orderId)
        {
           return Orders.FirstOrDefault(p=>p.OrderId == orderId);
        }
    }
}
