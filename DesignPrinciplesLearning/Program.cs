using SimUDuck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckProcessor duckProcessor = new DuckProcessor();

            duckProcessor.ListDucks();


            Console.ReadKey();
        }
    }

    
}
