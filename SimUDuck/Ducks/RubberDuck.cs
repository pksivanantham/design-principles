namespace SimUDuck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehaviour = new Squeak();
            flyBehaviour = new FlyNoWay();
        }


    }

}
