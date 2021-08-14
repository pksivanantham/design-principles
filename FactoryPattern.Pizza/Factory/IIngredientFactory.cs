using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Pizza.Factory
{
    public interface IIngredientFactory
    {
        Dough CreateDough();

        Sauce CreateSauce();
    }
}
