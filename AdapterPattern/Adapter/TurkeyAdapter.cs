using System.Linq;

namespace AdapterPattern.Adapter
{
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey) => _turkey = turkey;

        public void Fly()
        {
            Enumerable.Range(1, 5).ToList().ForEach(x => _turkey.Fly());
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
