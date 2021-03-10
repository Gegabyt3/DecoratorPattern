// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShop1.Models;

namespace CoffeeShop1.Controllers
{
    // This MVC program demonstrates the decorator design pattern by "decorating"
    // a coffee beverage with extra additions like sugar/honey that increase the 
    // beverage's price and name. This allows for flexibility and extension.
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            Beverage aBeverage1 = new Latte();
            Sugar aSugar = new Sugar(aBeverage1);
            Honey aHoney = new Honey(aSugar, 1.0);
            Mocha aMocha1 = new Mocha(aHoney, 1.0);
            Mocha aMocha2 = new Mocha(aMocha1, 1.0);
            Mocha aMocha3 = new Mocha(aMocha2, 1.0);
            Espresso anEspresso1 = new Espresso(aMocha3, 1.0);
            Espresso anEspresso2 = new Espresso(anEspresso1, 1.0);

            ViewBag.CupOfCoffee = aBeverage1;


            return View();
        }
    }
}