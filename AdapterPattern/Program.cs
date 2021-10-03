using AdapterPattern.Adapter;
using AdapterPattern.FacadePattern;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            TestAdapter();

            TestFacade();

            Console.Read();

        }

        static void TestAdapter()
        {
            Console.WriteLine("Adapter Pattern:");
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
        }

        static void TestFacade()
        {
            Console.WriteLine("Facade Pattern:");

            var duck = new Duck();
            var turkey = new Turkey();

            var birdsFacade = new BirdsFacade(duck, turkey);

            birdsFacade.PerformDuck();
            birdsFacade.PerformTurkey();
        }
    }
}
