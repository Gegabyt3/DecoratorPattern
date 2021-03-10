// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop1.Models
{
    public class Latte : Beverage
    {
        public override string Name
        {

            get
            {
                return "Latte";
            }
        }
        public override double Price
        {
            get
            {
                return 2.99;
            }
        }
    }
}