using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.StarBuzzCoffee.Codiment
{
    public class Mocha : ContimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override int GetCost()
        {
           return  _beverage.GetCost() + 1;
        }
        public override string GetDesc()
        {
            return _beverage.GetDesc() + ",  Mocha";
        }
    }
}
