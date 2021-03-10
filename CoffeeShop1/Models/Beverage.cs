// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop1.Models
{
    public class Beverage
    {
        protected string name = "n/a";
        protected double price = 999.9;

        public virtual string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public virtual double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }


    }
}