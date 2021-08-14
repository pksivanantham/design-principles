using FactoryPattern.Pizza.Factory;


namespace FactoryPattern.Pizza
{
    public class SimplePizzaStore
    {
        private ISimplePizzaFactory _simplePizzaFactory;
        public SimplePizzaStore(ISimplePizzaFactory simplePizzaFactory)
        {
            _simplePizzaFactory = simplePizzaFactory;
        }
        public IPizza OrderPizza(PizzaType pizzaType)
        {
            IPizza pizza;

            pizza = _simplePizzaFactory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        
    }
}
