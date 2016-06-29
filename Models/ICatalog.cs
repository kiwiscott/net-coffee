using System;
using System.Collections.Generic;

namespace Coffee.Models
{
    public interface ICatalog
    {
        IEnumerable<CoffeeCatalogItem> Catalog(string filter);
        int ReserveProducts(IEnumerable<Reservation> reservations);
    }

    public interface IOrder
    {

    }

    public class Order
    {
        public IEnumerable<OrderLine> Products {get;set;}
        public Address ShipToAddress {get;set;}
    }

    public class OrderResponse
    {
        public int Id  {get;set;}
        public DateTime ShipmentEta {get;set;}
    }

    public class OrderLine 
    {
        public int Product {get;set;}
        public string Size {get;set;}
        public int Quantity {get;set;}
    }


    public class Reservation 
    {
        public int Product {get;set;}
        public string Size {get;set;}
        public int Quantity {get;set;}
    }

    public class Address
    {
        public string City {get;set;}
        public string Number {get;set;}
        public string State {get;set;}
        public string Street {get;set;}
        public string Zip {get;set;}
    }
}














