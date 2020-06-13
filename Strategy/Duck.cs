using System;

namespace Strategy
{
    public abstract class Duck
    {
        public IFlyDuck FlyBehavior { get; set; }
        public IQuackDuck QuackBevavior { get; set; }

        public string Name;

        public void PerformFly()
        {
            if (FlyBehavior != null)
                FlyBehavior.Fly();
            else
                Console.WriteLine("Уточка не умеет летать!");
        }
    }
}