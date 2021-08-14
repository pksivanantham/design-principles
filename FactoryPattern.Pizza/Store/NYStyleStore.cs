using FactoryPattern.Pizza.Factory;
using System;

namespace FactoryPattern.Pizza
{
    public class NYStyleStore : PizzaStore
    {
        private IIngredientFactory _ingredientFactory = new ChicagoIngredientFactory();

        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = default(Pizza);

            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    pizza = new NyStyleCheesePizza(_ingredientFactory);
                    pizza.Name = "NY Cheese";
                    break;
                case PizzaType.Pepperoni:
                    pizza = new NyStyleCheesePizza(_ingredientFactory);
                    pizza.Name = "NY Pepperoni";
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
