using DecoratorPattern.StarBuzzCoffee.Codiment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.StarBuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage coffee = new Espresso();

            coffee = new Cream(coffee);//warapping into decorator

            coffee = new Cream(coffee);

            coffee = new Mocha(coffee);

            coffee = new Mocha(coffee);

            Console.WriteLine(coffee.GetDesc());

            Console.WriteLine(coffee.GetCost());

            Console.ReadKey();
        }
    }
}
