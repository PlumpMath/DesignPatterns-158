namespace DesignPatternsLibrary.CompositePattern
{
    /// <summary>
    /// This class represents the simple product
    /// </summary>
    public class SimpleProduct : IProduct
    {
        private readonly string _name;
        private readonly double _price;
   
        public SimpleProduct(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string Name
        {
            get { return _name; }
        }

        public double Price
        {
            get { return _price; }
        }
    }
}
