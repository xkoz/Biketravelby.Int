using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Biketravelby.Int.Core;

namespace Biketravelby.Int.DAL
{
    
    public class BiketravelbyIntDbContext : DbContext
    {
        public BiketravelbyIntDbContext() : base("DefaultConnection") { }
        public DbSet<Address> Address { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Passport> Passport { get; set; }
        public DbSet<Visa> Visa { get; set; }

        public DbSet<Ads> Ads { get; set; }

    }
}