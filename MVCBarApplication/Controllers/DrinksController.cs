using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBarApplication.Models;

namespace MVCBarApplication.Controllers
{
    public class DrinksController : Controller
    {
        // GET: Drinks
        public ActionResult Menu()
        {
            DrinksContext drinksContext = new DrinksContext();
            Drinks[] drinks = drinksContext.Drinks.ToArray();
            return View(drinks);
        }
    }
}