using RenderPartialView_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RenderPartialView_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerContext db = new CustomerContext();

        public ActionResult Index()
        {
            var customers = db.Customers.ToList();
            return View(customers);
        }

        public PartialViewResult Customers()
        {
            var customers = db.Customers.ToList();
            return PartialView("_Customers",customers);
        }
    }
}