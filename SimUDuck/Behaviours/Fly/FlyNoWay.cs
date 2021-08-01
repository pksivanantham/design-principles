using System;

namespace SimUDuck
{
    public class FlyNoWay : IFlyBehaviour
    {
        void IFlyBehaviour.Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

}
