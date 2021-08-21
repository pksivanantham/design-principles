using System;
using System.Threading;

namespace Learning.Singleton
{
    public sealed class Singleton
    {
        private static readonly object _padLock = new object();

        private static Singleton _singleton;

        private static readonly Singleton _singletonWithEagarLoading = new Singleton();//Will be created by CLR.So we no need to worry about multithreading issues.Basically it's thread safe

        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        private Singleton() => InstantiatedTime = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss:zzz");


        public static Singleton Instance
        {
            get
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : Called at {DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ssss")}");

                //Double checked locking
                if (_singleton == null)//Use lock only for the first time to avoid performance overhead
                {
                    lock (_padLock)
                    {
                        if (_singleton == null)//Lazy loading so that object wont be created unless there is an first use
                            _singleton = new Singleton();
                    }
                }
                return _singleton;

            }
        }


        public Singleton InstanceWithEagarLoading { get => _singletonWithEagarLoading;  }

        public Singleton LazyInstance { get => lazy.Value; }
        public string InstantiatedTime { get; set; }
    }
}
