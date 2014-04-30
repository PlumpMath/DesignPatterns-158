using System;

namespace DesignPatternsLibrary.ObserverPattern
{
    /// <summary>
    /// Bidders to the auction. They register themselves with the
    /// auction so that they are notified when the state of the 
    /// auction has changed. (i.e. someone has put out a higher bid)
    /// </summary>
    public class Bidder : IBidder
    {
        private IBidList _auction; //subject

        public Bidder(IBidList subject)
        {
            _auction = subject;
            _auction.RegisterBidder(this);
        }

        public void Update(Bid newBid) //lasted bid
        {
            Console.WriteLine("The lasted bid is " + newBid);
        }

    }
}
