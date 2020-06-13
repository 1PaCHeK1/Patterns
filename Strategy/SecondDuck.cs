namespace Strategy
{
    public class SecondDuck : Duck
    {
        public SecondDuck()
        {
            FlyBehavior = new Flyyyy();
            QuackBevavior = null;
        }
    }
}