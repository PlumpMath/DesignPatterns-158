

using System.Collections.Generic;
using Common.Helpers;

namespace DesignPatternsLibrary.CompositePattern
{
    public class ComposedProduct : IProduct
    {
        public List<IProduct> Products { get; set; }

        public ComposedProduct()
        {
            Products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }

        public string Name { 
            get
            {
                string name = string.Empty;
                Products.For((p, index) =>
                    {
                        if (index > 0) name += ", ";
                        name += p.Name;
                    });
                return name;
            } 
        }

        public double Price
        {
            get
            {
                double priceTotal = 0;
                Products.ForEach(p => { priceTotal += p.Price; });
                return priceTotal;
            }
        }
    }
}
