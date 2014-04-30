namespace DesignPatternsLibrary.ObserverPattern
{
    /// <summary>
    /// This interface represents the subject
    /// 
    /// Objects implementing this interface allow observers
    /// to register with it. When this object changes state,
    /// it notifies all registered observers.
    /// </summary>
    public interface IBidList
    {
        /* allows an Bidder to register with the subject */
        void RegisterBidder(IBidder bidder);

        /* removes an Bidder */
        void RemoveBidder(IBidder bidder);

        /* notifes all registered Bidders when its state changes */
        void NotifyBidders();
    }
}
