namespace FactoryPattern.Pizza.Factory
{
    public class NYIngredientFactory : IIngredientFactory
    {
        public Dough CreateDough() => new Dough();

        public Sauce CreateSauce() => new Sauce();
    }
}
