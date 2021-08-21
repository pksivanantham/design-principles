using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning.Singleton
{
    public class Singleton
    {
        private static readonly object _singletonLock = new object();

        private static Singleton _singleton;

        private string instantiatedTime;
        private Singleton() => instantiatedTime = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss:zzz");


        public static Singleton Instance
        {
            get
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : Called at {DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ssss")}");

                lock(_singletonLock)
                {
                    if (_singleton == null)
                        _singleton = new Singleton();

                    return _singleton;
                }
               
            }
        }

        public string InstantiatedTime { get => instantiatedTime; set => instantiatedTime = value; }
    }
}
