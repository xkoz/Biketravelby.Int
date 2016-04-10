using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Biketravelby.Int.Models
{
    public class ClientsModel
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Birthday { get; set; }

    }

    public class AddressModel
    {
    }

    public class PassportModel
    { }
}