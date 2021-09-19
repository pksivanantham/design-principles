using System;

namespace AdapterPattern
{
    public class Duck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Hey I am flying..");
        }

        public void Quack()
        {
            Console.WriteLine("Quack...........");

        }
    }
}
