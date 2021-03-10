// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop1.Models
{
    public class Mocha: BeverageDecorator
    {
        public Mocha(Beverage aBeverage, double aCost)
        {
            beverage = aBeverage;
            beverage.Name = "Mocha " + beverage.Name;
            beverage.Price = beverage.Price + 0.50;

        }

    }
}