using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.StarBuzzCoffee
{
    public class Espresso : Beverage
    {
        public Espresso() => _desc = "Espresso";
        public override int GetCost() => 10;
    }
}
