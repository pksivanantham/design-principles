namespace FactoryPattern.Pizza.Factory
{
    public interface ISimplePizzaFactory
    {
        IPizza CreatePizza(PizzaType pizzaType);
    }
}
