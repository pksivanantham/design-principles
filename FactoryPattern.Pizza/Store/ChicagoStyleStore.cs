using FactoryPattern.Pizza.Factory;
using System;

namespace FactoryPattern.Pizza
{
    public class ChicagoStyleStore : PizzaStore
    {
        private IIngredientFactory _ingredientFactory = new NYIngredientFactory();
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = default(Pizza);

            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    pizza =  new ChicagoStyleCheesePizza(_ingredientFactory);
                    pizza.Name = "Chicago Cheese";
                    break;
                case PizzaType.Pepperoni:
                    pizza = new ChicagoStyleCheesePizza(_ingredientFactory);
                    pizza.Name = "Chicago Pepperoni";

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
