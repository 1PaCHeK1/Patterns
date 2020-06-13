using System;
using System.Collections.Generic;

namespace Command
{
    public class CommandClass1 : ICommand
    {
        private Class1 obj;
        private Stack<int> PrefValue;

        public CommandClass1(Class1 _obj) => (obj, PrefValue) = (_obj, new Stack<int>());

        public void Execute()
        {
            PrefValue.Push(obj.Value);
            Console.WriteLine($"Вы вызвали этот метод {obj.Value++} раз");
        }

        public void Undo() => obj.Value = PrefValue.Pop();
    }
}