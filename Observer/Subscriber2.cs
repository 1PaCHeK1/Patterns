using System;

namespace Observer
{
    class Subscriber2 : ISubscriber
    {
        private Subject subject;

        public Subscriber2(Subject subject) => this.subject = subject;

        public int Value { get; private set; } = 0;

        public void update(int Value)
        {
            Console.WriteLine($"Вызван метод update в классе {this.GetType()}");
            this.Value += Value;
        }
    }
}
