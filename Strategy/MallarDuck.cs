namespace Strategy
{
    public class MallarDuck : Duck
    {
        public MallarDuck()
        {
            FlyBehavior = new Fly1();
            QuackBevavior = null;
        }
    }
}
