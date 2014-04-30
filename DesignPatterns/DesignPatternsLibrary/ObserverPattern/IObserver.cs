using System;

namespace DesignPatternsLibrary.ObserverPattern
{
    public interface IObserver
    {
        void Update(Object newState);
    }
}
