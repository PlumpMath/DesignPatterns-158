namespace DesignPatternsLibrary.ObserverPattern
{
    public interface ISubject
    {
        void NotifyObservers();
        void RegisterObserver();
        void RemoveObserver();
    }
}
