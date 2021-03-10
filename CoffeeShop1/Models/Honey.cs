// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop1.Models
{
    public class Honey:BeverageDecorator
    {
        public Honey(Beverage aBeverage, double aCost)
        {
            beverage = aBeverage;
            beverage.Name = "Honey " + beverage.Name;
            beverage.Price = beverage.Price + 0.75;

        }
    }
}