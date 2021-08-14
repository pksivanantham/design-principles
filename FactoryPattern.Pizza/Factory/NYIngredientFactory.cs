using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Pizza.Factory
{
    public class NYIngredientFactory : IIngredientFactory
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
