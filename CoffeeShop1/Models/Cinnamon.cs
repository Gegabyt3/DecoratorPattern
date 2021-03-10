// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop1.Models
{
    public class Cinnamon:BeverageDecorator
    {
        public Cinnamon(Beverage aBeverage, double aCost)
        {
            beverage = aBeverage;
            beverage.Name = "Cinnamon " + beverage.Name;
            beverage.Price = beverage.Price + 0.70;

        }
    }
}