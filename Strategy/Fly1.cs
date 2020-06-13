using System;

namespace Strategy
{
    internal class Fly1 : IFlyDuck
    {
        private int height = 100;

        public void Fly()
        {
            Console.WriteLine($"Уточка летит на высоте {height}");
        }
    }
}