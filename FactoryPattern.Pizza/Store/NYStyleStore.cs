using System;

namespace FactoryPattern.Pizza
{
    public class NYStyleStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = default(Pizza);

            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    pizza = new NyStyleCheesePizza();
                    break;
                case PizzaType.Pepperoni:
                    break;
                case PizzaType.Veggie:
                    break;
                case PizzaType.Margherita:
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
