using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.StarBuzzCoffee.Coffees
{
    public class Latte : Beverage
    {
        public Latte() => _desc = "Lotte";
        public override int GetCost() => 20;
    }
}
