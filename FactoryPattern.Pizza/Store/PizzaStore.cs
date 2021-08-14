using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Pizza
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType pizzaType)
        {
            Pizza pizza;

            pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        protected abstract Pizza CreatePizza(PizzaType pizzaType);
    }
}
