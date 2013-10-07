using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSKU.Models
{
    public class Unit
    {
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}