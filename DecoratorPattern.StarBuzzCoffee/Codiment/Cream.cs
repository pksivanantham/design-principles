using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.StarBuzzCoffee.Codiment
{
    public class Cream : ContimentDecorator
    {
        private readonly Beverage _beverage;

        public Cream(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override int GetCost()
        {
           return  _beverage.GetCost() + 2;
        }
        public override string GetDesc()
        {
            return _beverage.GetDesc() + ",  Cream";
        }
    }
}
