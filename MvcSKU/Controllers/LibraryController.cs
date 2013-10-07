using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSKU.Models;

namespace MvcSKU.Controllers
{
    public class LibraryController : Controller
    {
        //
        // GET: /Library/

        public ActionResult Index()
        {
            var manufacturers = new List<Manufacturer>
            {
              new Manufacturer { Name = "Post" },
              new Manufacturer { Name = "Kellogg's" },
              new Manufacturer { Name = "Campbell's" }
            };

            return View(manufacturers);
        }
        //
        // GET: /Library/Browse?manufacturer=Post
        public ActionResult Browse(string manufacturer)
        {
            var manufacturerModel = new Manufacturer { Name = manufacturer };

            return View(manufacturerModel);
        }
        //
        // GET: /Library/Details/5
        public ActionResult Details(int id)
        {
            var unit = new Unit { Name = "Unit " + id };

            return View(unit);
        }
    }
}
