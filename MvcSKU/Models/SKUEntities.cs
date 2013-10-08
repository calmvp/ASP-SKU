using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcSKU.Models
{
    public class SKUEntities : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}