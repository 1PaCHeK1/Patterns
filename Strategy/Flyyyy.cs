using System;

namespace Strategy
{
    class Flyyyy : IFlyDuck
    {
        int height = 300;
        public void Fly()
        {
            Console.WriteLine($"Уточка летит на высоте {height}");
        }
    }
}
