namespace DesignPatternsLibrary.CompositePattern
{
    /// <summary>
    /// This interface represents the definition of the product
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Gets the name of the product
        /// </summary>
        /// <value>
        /// The name of the product
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets the price of the product
        /// </summary>
        /// <value>
        /// The price of the product
        /// </value>
        double Price { get; }
    }
}
