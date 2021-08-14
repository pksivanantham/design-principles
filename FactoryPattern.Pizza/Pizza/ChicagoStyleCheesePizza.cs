using System;

namespace FactoryPattern.Pizza
{
    public class ChicagoStyleCheesePizza : Pizza
	{
		public ChicagoStyleCheesePizza() : base()
		{
			name = "Chicago style cheese pizza";
			dough = "Thin crust dough";
			sauce = "Marinara sauce";
			toppings.Add("cheese");

		}

		public override void Cut()
        {
            Console.WriteLine("Cutting to ****Square***** slices");
        }
	}

}
