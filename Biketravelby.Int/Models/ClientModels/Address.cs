using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biketravelby.Int.Models.ClientModels
{
    public class Address
    {
        public int AddressID { get; set; }

        public string Index { get; set; }
        
        public string Country { get; set; }
        
        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Flat { get; set; }
    }
}