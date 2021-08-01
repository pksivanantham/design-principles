namespace SimUDuck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehaviour = new Squeak();
            flyBehaviour = new FlyNoWay();
        }

        public override void Display()
        {
            System.Console.WriteLine("Rubber duck---");
        }
    }

}
