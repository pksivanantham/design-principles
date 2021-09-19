using AdapterPattern.Adapter;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new Duck();
            var turkey = new Turkey();

            Console.WriteLine("converting turkey to duck");
            IDuck duckAdaptee = new TurkeyAdapter(turkey);
            duckAdaptee.Quack();
            duckAdaptee.Fly();

            Console.WriteLine("converting duck to turkey");

            ITurkey turkeyAdaptee = new DuckAdapter(duck);
            turkeyAdaptee.Gobble();
            turkeyAdaptee.Fly();

            Console.Read();

        }
    }
}
