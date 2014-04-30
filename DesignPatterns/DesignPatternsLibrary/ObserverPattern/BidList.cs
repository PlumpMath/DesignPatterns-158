using System.Collections.Generic;

namespace DesignPatternsLibrary.ObserverPattern
{
    public class BidList : IBidList
    {
        private List<IBidder> _biddersObservers;
        private Bid _lastedBid;

        public BidList()
        {
            _biddersObservers = new List<IBidder>();
        }

        public void RegisterBidder(IBidder bidder)
        {
            _biddersObservers.Add(bidder);
        }

        public void RemoveBidder(IBidder bidder)
        {
            _biddersObservers.Remove(bidder);
        }

        /* bidders invoke this method when they submit a bid */ 
        public void SubmitBid(Bid lastedBid)
        {
            _lastedBid = lastedBid;
            //notify all registered bidders - observers
            NotifyBidders();
        }

        public void NotifyBidders()
        {
            foreach (IBidder bidder in _biddersObservers)
            {
                bidder.Update(_lastedBid);
            }
        }
    }
}
