using System;
using DesignPatternsLibrary.ObserverPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.ObserverPattern
{
    [TestClass]
    public class AuctionTest
    {
        /// <summary>
        ///  Provide an auction whereby bidders register with the BidList.
        ///  Bidders may then submit bids and all bidders are notified when 
        ///  a bid is made.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            BidList auction = new BidList();

            // create some bidders
            Bidder amy = new Bidder(auction);
            Bidder julie = new Bidder(auction);
            Bidder pat = new Bidder(auction);

            // submit some bids to the auction 
            auction.SubmitBid(new Bid { Name = "Amy", Value = 150});
            auction.SubmitBid(new Bid { Name = "Julie", Value = 160 });
            auction.SubmitBid(new Bid { Name = "Amy", Value = 165 });
            auction.SubmitBid(new Bid { Name = "Julie", Value = 170 });
            auction.SubmitBid(new Bid { Name = "Pat", Value = 175 });

            // The bidding has gone too high for Amy.
            auction.RemoveBidder(amy);

            // few more bids
            auction.SubmitBid(new Bid { Name = "Julie", Value = 180 });
            auction.SubmitBid(new Bid { Name = "Pat", Value = 185 });

            // now too high for Julie
            auction.RemoveBidder(julie);

            // this doesn't make sense, but just to show that
            // there is now only one observer (Pat)
            auction.SubmitBid(new Bid { Name = "Pat", Value = 190 });
        }
    }
}
