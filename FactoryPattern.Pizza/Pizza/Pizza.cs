using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizza
{
    public abstract class Pizza 
	{
		protected string name;
		protected string dough;
		protected string sauce;
		protected List<string> toppings = new List<string>();

		public string GetName()
		{
			return name;
		}

		public virtual void Prepare()
		{
			Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough");
            Console.WriteLine("Tossing sauce");
            Console.WriteLine("Tossing toppings");
			toppings?.ForEach((item) => Console.WriteLine($"  {item}"));
		}

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
