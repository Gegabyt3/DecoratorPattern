// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop1.Models
{
    public class Cappuccino : Beverage
    {
        public override string Name
        {

            get
            {
                return "Cappuccino";
            }
        }
        public override double Price
        {
            get
            {
                return 3.99;
            }
        }
    }
}