using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.FacadePattern
{
    public class BirdsFacade
    {
        private readonly IDuck _duck;
        private readonly ITurkey _turkey;

        public BirdsFacade(IDuck duck,ITurkey turkey)
        {
            _duck = duck;
            _turkey = turkey;
        }

        public void PerformDuck()
        {
            _duck.Quack();
            _duck.Fly();
        }

        public void PerformTurkey()
        {
            _turkey.Gobble();
            _turkey.Fly();
        }
    }
}
