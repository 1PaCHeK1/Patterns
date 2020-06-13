using System;

namespace Decorator
{
    internal class Program
    {
        /// <summary>
        /// Здесь мы используем паттерн Декоратор
        /// </summary>
        private static void Main()
        {
            Beverage beverage = new Expresso();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Milk(beverage);
            Console.WriteLine($"Напиток обошелся в {beverage.Cost()} рублей, в напитке {beverage.GetDescription()}");
        }
    }
}