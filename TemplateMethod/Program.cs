using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    class Program
    {
        /// <summary>
        /// Здесь мы использовали простой шаблонный метод Array.Sort 
        /// Для его реализации нам было необходимо наследовать интерфейс IComparable<T> и реализовать его метод CompareTo(T) в классе T
        /// В нашем случае класс T = Item
        /// </summary>
        static void Main()
        {
            var items = new List<Item>() { new Item(7), new Item(23), new Item(1), new Item(2), new Item(100), new Item(45) };

            items.Sort();

            foreach (var i in items)
                Console.WriteLine(i.Value);
        }
    }
}
