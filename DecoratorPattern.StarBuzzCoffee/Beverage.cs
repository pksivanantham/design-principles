using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.StarBuzzCoffee
{
    public abstract class Beverage
    {
        protected string _desc = "Unknown";
        public abstract int GetCost();

        public virtual string GetDesc() => _desc;
    }
}
