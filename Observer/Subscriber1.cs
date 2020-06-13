using System;

namespace Observer
{
    public class Subscriber1 : ISubscriber
    {
        Subject subject;
        public Subscriber1(Subject subject) => this.subject = subject;
        public int Value { get; private set; } = 0;
        public void update(int Value)
        {
            Console.WriteLine($"Вызван метод update в классе {this.GetType()}");
            this.Value += Value;
        }
    }
}
