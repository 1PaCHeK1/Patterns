using System.Collections.Generic;

namespace Observer
{
    public class Subject : ISubject
    {
        List<ISubscriber> Subscribers;
        public Subject()
        {
            Subscribers = new List<ISubscriber>();
        }
        public int Value { get; set; }

        public void AddSubsriber(ISubscriber subsriber) => Subscribers.Add(subsriber);
        
        public void RemoveSubsriber(ISubscriber subsriber) => Subscribers.Remove(subsriber);

        public void NotifySubsribers()
        {
            foreach (var i in Subscribers)
                i.update(Value);
        }
    }
}
