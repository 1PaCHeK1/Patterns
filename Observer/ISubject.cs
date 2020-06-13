namespace Observer
{
    public interface ISubject
    {
        void AddSubsriber(ISubscriber subsriber);
        void RemoveSubsriber(ISubscriber subsriber);
        void NotifySubsribers();
    }
}
