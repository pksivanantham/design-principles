namespace SimUDuck
{
    public class Duck
    {
        public IFlyBehaviour flyBehaviour;
        public IQuackBehaviour quackBehaviour;

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

    }


}
