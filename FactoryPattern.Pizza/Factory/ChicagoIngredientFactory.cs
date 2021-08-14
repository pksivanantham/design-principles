namespace FactoryPattern.Pizza.Factory
{
    public class ChicagoIngredientFactory : IIngredientFactory
    {
        Dough IIngredientFactory.CreateDough()
        {
            return new Dough();
        }

        Sauce IIngredientFactory.CreateSauce()
        {
            return new Sauce();
        }
    }
}
