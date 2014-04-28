using DesignPatternsLibrary.CompositePattern;

namespace DesignPatternsLibrary.DecoratorPattern
{
    /// <summary>
    /// A decorator for an product that applies a discount 
    /// </summary>
    public class DiscountProduct : IProduct
    {
        private double _discount;
        private IProduct _product;

        public DiscountProduct(IProduct product, double discount)
        {
            _product = product;
            _discount = discount;
        }

        public string Name { get { return _product.Name; } }

        //apply discount
        public double Price { 
            get
            {
                return _product.Price * (1 - _discount);
            } 
        }
    }
}
