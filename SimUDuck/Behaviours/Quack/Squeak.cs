using System;

namespace SimUDuck
{
    public class Squeak : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("Squeak");
        }
    }

}
