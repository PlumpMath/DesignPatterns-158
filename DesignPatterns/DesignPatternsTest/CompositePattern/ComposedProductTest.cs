using System;
using DesignPatternsLibrary.CompositePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.CompositePattern
{
    [TestClass]
    public class ComposedProductTest
    {
        [TestMethod]
        public void AddSimpleProducts()
        {
            ComposedProduct composedProduct = new ComposedProduct();
            composedProduct.AddProduct(new SimpleProduct("Iogurte", 2.40));
            composedProduct.AddProduct(new SimpleProduct("Leite", 2.00));
            Assert.AreEqual(2,composedProduct.Products.Count);
        }

        [TestMethod]
        public void GetPrice()
        {
            ComposedProduct composedProduct = new ComposedProduct();
            composedProduct.AddProduct(new SimpleProduct("Iogurte", 2.40));
            composedProduct.AddProduct(new SimpleProduct("Leite", 2.00));
            Assert.AreEqual(4.40, composedProduct.Price);
        }

        [TestMethod]
        public void AddComposedProducts()
        {
            ComposedProduct composedProduct1 = new ComposedProduct();
            composedProduct1.AddProduct(new SimpleProduct("Product 1", 2.40));
            composedProduct1.AddProduct(new SimpleProduct("Product 2", 2.00));

            ComposedProduct composedProduct2 = new ComposedProduct();
            composedProduct2.AddProduct(composedProduct1);
            composedProduct2.AddProduct(new SimpleProduct("Product 3", 1.00));

            foreach (IProduct p in composedProduct2.Products)
            {
                Console.WriteLine("Product [ Price: {0}, Name: {1} ] ",p.Price,p.Name);
            }

        }

       
    }
}
