using System;

namespace AdapterPattern.Adapter
{
    public class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;

        public DuckAdapter(IDuck duck) => _duck = duck;
        public void Fly()
        {           
            if (new Random().Next(5) == 0)
                _duck.Fly();

        }

        public void Gobble()
        {
            _duck.Quack();
        }
    }
}
