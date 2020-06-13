namespace Observer
{
    class Program
    {
        /// <summary>
        /// Здесь мы используем паттерн Наблюдатель
        /// </summary>
        static void Main()
        {
            Subject subject = new Subject { Value = 10 };
            
            var sub1 = new Subscriber1(subject);
            var sub2 = new Subscriber2(subject);

            subject.AddSubsriber(sub1);
            subject.AddSubsriber(sub2);

            subject.NotifySubsribers();
            subject.Value += 5;
            subject.NotifySubsribers();
            subject.RemoveSubsriber(sub2);
            subject.Value += 5;
            subject.NotifySubsribers();
        }
    }
}
