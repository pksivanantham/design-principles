using SimUDuck.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class DuckProcessor
    {
        public void ListDucks()
        {
            List<Duck> ducks = new List<Duck>();
            ducks.Add(new MallardDuck());
            ducks.Add(new RubberDuck());

            foreach (var item in ducks)
            {
                item.Display();
                item.Swim();                
                item.PerformFly();
                item.PerformQuack();


                item.SetQuackBehaviour(new MuteQuack());
                item.PerformQuack();

            }
        }
    }
}

