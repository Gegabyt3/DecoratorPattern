// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop1.Models
{
    public class FrenchRoast : Beverage
    {
        public override string Name
        {

            get
            {
                return "French Roast";
            }
        }
        public override double Price
        {
            get
            {
                return 1.99;
            }
        }

    }
}