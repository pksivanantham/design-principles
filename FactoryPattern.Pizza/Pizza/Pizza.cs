using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizza
{
    public abstract class Pizza 
	{
        public string Name { get; set; }
        protected Dough dough;
		protected Sauce sauce;
		protected List<string> toppings = new List<string>();

		public abstract void Prepare();
		

		public virtual void Bake()
		{
			Console.WriteLine("Bake for 25 mins at 350");
		}

		public virtual void Cut()
		{
			Console.WriteLine("Cutting into diagnoal slices");
		}

		public virtual void Box()
		{
			Console.WriteLine("Placing pizza into official pizza box" );
		}

		//public override string ToString()
		//{
		//	// code to display pizza name and ingredients
		//	StringBuilder display = new StringBuilder();
		//	display.Append("---- " + name + " ----\n");
		//	display.Append(dough + "\n");
		//	display.Append(sauce + "\n");
		//	foreach (string topping in toppings)
		//	{
		//		display.Append(topping + "\n");
		//	}
		//	return display.ToString();
		//}
	}

}
