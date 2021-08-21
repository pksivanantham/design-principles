namespace Learning.Singleton
{
    public sealed class SingletonFullLazy
    {

        private SingletonFullLazy()
        {

        }

        public static  SingletonFullLazy Instance { get => Nested.instance; }

        public class Nested
        {
            static Nested()
            {

            }

            internal static readonly SingletonFullLazy instance = new SingletonFullLazy();
        }
    }
}
