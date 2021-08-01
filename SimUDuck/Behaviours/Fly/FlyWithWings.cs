using System;

namespace SimUDuck
{
    public class FlyWithWings : IFlyBehaviour
    {
        void IFlyBehaviour.Fly()
        {
            Console.WriteLine("Flying");
        }
    }

}
