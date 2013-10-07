﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSKU.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Unit> Units { get; set; }
    }
}