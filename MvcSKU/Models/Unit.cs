using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSKU.Models
{
    public abstract class Unit
    {
        public int UnitId { get; set; }
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }

    public class Box : Unit
    { 
    
    }

    public class Can : Unit
    {
        public decimal Radius { get; set; }
    }

    public class SoftPack : Unit
    {
        public decimal EdgeRadius { get; set; }
    }

    public class InheritanceMappingContext : DbContext
    {
        public DbSet<Unit> Units { get; set; }
    }
}