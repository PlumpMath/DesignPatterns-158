namespace DesignPatternsLibrary.ObserverPattern
{
    /// <summary>
    /// This interface represents the Observer
    /// 
    /// Observers implement this interface so that
    /// their update() method is called by the subject
    /// when the state of the subject changes.
    /// </summary>
    public interface IBidder
    {
        /// <summary>
        /// This method is called when the state (bid) of the subject
        /// </summary>
        /// <param name="newBid">the new state (new bid) of the subject</param>
        void Update(Bid newBid);
    }
}
