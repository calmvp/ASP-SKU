using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSKU.Models
{
    public class SKUEntities : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}