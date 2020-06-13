using System;

namespace Singleton
{
    class Program
    {
        /// <summary>
        /// Здесь мы реализуем паттерн Одиночка
        /// </summary>
        static void Main()
        {
            var st1 = Singleton.GetInstance();
            var st2 = Singleton.GetInstance();

            Console.WriteLine(st1.GetHashCode());
            Console.WriteLine(st2.GetHashCode());
        }
    }
}