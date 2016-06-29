using System;
using System.Collections.Generic;

namespace Coffee.Models
{
    public class Tracking
    {
        public string Shipper {get;set;}
        public string Status {get;set;}
        public string TrackingIdentifier {get;set;}
        public string UrlToTrack {get;set;}
    }
}
