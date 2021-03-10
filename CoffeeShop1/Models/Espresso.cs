// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop1.Models
{
    public class Espresso:BeverageDecorator
    {
        public Espresso(Beverage aBeverage, double aCost)
        {
            beverage = aBeverage;
            beverage.Name = "Espresso " + beverage.Name;
            beverage.Price = beverage.Price + 1.50;

        }
    }
}