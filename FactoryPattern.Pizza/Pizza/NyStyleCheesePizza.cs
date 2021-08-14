namespace FactoryPattern.Pizza
{
    public class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza():base()
        {
			name = "NY style cheese pizza";
			dough = "Thin crust dough";
			sauce = "Marinara sauce";
			toppings.Add("cheese");
			
        }
    }

}
