// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop1.Models
{
    public class BeverageDecorator: Beverage
    {
        protected Beverage beverage;
    }
}