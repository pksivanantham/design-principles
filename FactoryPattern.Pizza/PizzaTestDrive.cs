using FactoryPattern.Pizza.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Pizza
{
    public static class PizzaTestDrive
    {

        public static void Main(string[] args)
        {
            //Simple Factory

            ISimplePizzaFactory simplePizzaFactory = new SimplePizzaFactory();
            ISimplePizzaFactory simplePizzaFactory1 = new SimplePizzaFactory();

            SimplePizzaStore simplePizzaStore = new SimplePizzaStore(simplePizzaFactory);
            SimplePizzaStore simplePizzaStore1 = new SimplePizzaStore(simplePizzaFactory1);

            simplePizzaStore.OrderPizza(PizzaType.Cheese);
            simplePizzaStore1.OrderPizza(PizzaType.Margherita);


            PizzaStore nyPizzaStore = new NYStyleStore();
            PizzaStore ChicagoPizzaStore = new ChicagoStyleStore();


            nyPizzaStore.OrderPizza(PizzaType.Cheese);
            ChicagoPizzaStore.OrderPizza(PizzaType.Cheese);


            Console.ReadKey();

        }
    }
}
