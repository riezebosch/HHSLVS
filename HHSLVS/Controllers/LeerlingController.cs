using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HHSLVS.Controllers
{
    public class LeerlingController : Controller
    {
        SchoolContext _context = new SchoolContext();

        // GET: Leerling
        public ActionResult Index()
        {
            var leerlingen = _context.Leerlingen;

            return View(leerlingen);
        }

        public ActionResult Edit(int id)
        {
            var leerling = _context
                .Leerlingen
                .FirstOrDefault(
                    l => l.Id == id);
            return View(leerling);
        }
    }
}