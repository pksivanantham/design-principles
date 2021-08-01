namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            System.Console.WriteLine("Mallard duck----");
        }
    }

}
