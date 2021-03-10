// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop1.Models
{
    public class Sugar:BeverageDecorator
    {
        public Sugar(Beverage aBeverage)
        {
            beverage = aBeverage;
            beverage.Name = beverage.Name + "with Sugar";


        }
    }
}