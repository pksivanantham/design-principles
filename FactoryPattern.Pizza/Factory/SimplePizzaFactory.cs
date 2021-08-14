namespace FactoryPattern.Pizza.Factory
{
    public class SimplePizzaFactory: ISimplePizzaFactory
    {
        public IPizza CreatePizza(PizzaType pizzaType)
        {

            switch (pizzaType)
            {
                case PizzaType.Cheese:
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

            return default(IPizza);
        }
    }
}
