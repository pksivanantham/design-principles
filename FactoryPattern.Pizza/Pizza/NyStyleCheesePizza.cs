using FactoryPattern.Pizza.Factory;
using System;

namespace FactoryPattern.Pizza
{
    public class NyStyleCheesePizza : Pizza
    {
        IIngredientFactory _ingredientFactory;
        public NyStyleCheesePizza(IIngredientFactory ingredientFactory) 
            => _ingredientFactory = ingredientFactory;

        public override void Prepare()
        {
            dough = _ingredientFactory.CreateDough();

            sauce = _ingredientFactory.CreateSauce();

            toppings.Add("cheese");


            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough");
            Console.WriteLine("Tossing sauce");
            Console.WriteLine("Tossing toppings");

            toppings?.ForEach((item) => Console.WriteLine($"  {item}"));
           
            
        }
    }

}
