using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Biketravelby.Int.Core
{
    public class Client
    {
        public int ClientID { get; set; }

        public string Name { get; set; }

        public string Surname { get;set;}

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public Address Address { get; set; }

        public Passport Passport { get; set; }

    }

    public enum Gender 
    {
        Female = 0,
        Male = 1
    }

    public class ClientDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}