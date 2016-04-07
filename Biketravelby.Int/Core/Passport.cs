using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biketravelby.Int.Models.ClientModels
{
    public class Passport
    {
        public int PassportID { get; set; }

        public string Number { get; set; }

        public string Issuer { get; set; }

        public DateTime ValidForm { get; set; }

        public DateTime ValidTo { get; set; }

        public List<Visa> Visas { get; set; }
    }

    public class Visa 
    {
        public int VisaID { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValitTo { get; set; }

        public VisaType Type { get; set; } 
    }

    public enum VisaType 
    {
        National = 0,
        Schengen = 1
    }
}