using System;
using System.Collections.Generic;

namespace Coffee.Models
{
    public class Order
    {
        public int OrderId {get;set;}
        public string Status {get;set;}
        public Tracking Tracking{get;set;}
        public IEnumerable<OrderLine> Products {get;set;}
        public Address ShipToAddress {get;set;}
    }

}
