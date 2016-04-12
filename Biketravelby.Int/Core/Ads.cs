using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biketravelby.Int.Core
{
    public class Ads
    {
        public int AdsID { get; set; }

        public string Title { get; set; }

        public DateTime Start { get; set; }

        public DateTime Finish { get; set; }

        public double? Price { get; set; }

        public string Comment { get; set; }
    }

}