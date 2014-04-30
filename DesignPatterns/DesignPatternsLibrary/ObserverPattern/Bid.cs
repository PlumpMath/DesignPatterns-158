namespace DesignPatternsLibrary.ObserverPattern
{
    /// <summary>
    /// This class represents a bid
    /// </summary>
    public class Bid
    {
        
        /// <summary>
        /// Gets or sets the name of the bid.
        /// </summary>
        /// <value>
        /// The name of the bid
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the bid.
        /// </summary>
        /// <value>
        /// The value of the bid
        /// </value>
        public int Value { get; set; }


        public override string ToString()
        {
            return Name + " - " + Value;
        }
    }
}
