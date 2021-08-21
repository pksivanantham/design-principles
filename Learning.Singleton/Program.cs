using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning.Singleton
{
    public class Program
    {

        public static void Main(string[] args)
        {

           // Action action = async () =>
           //{             
           //    Console.WriteLine(Singleton.Instance.InstantiatedTime);

           //    await Task.FromResult(10);
           //};

           // Parallel.Invoke(action, action, action, action);


            Thread thread1 = new Thread(new ThreadStart(Program.RunThread));
            thread1.Start();
            Thread thread2 = new Thread(new ThreadStart(Program.RunThread));
            thread2.Start();

            Console.ReadKey();

        }

        public static void RunThread()
        {
            Thread.Sleep(1000);

            Console.WriteLine(Singleton.Instance.InstantiatedTime);
        }
    }
}
