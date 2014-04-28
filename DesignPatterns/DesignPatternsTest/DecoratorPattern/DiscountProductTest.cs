using System;
using DesignPatternsLibrary.CompositePattern;
using DesignPatternsLibrary.DecoratorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.DecoratorPattern
{
    [TestClass]
    public class DiscountProductTest
    {
        [TestMethod]
        public void AppliesDiscountInTheSimpleProduct()
        {
            IProduct p = new SimpleProduct("Product 1", 4.00);

            //Applies 50% discount in the product p
            DiscountProduct dicountProduct = new DiscountProduct(p, 50.0 / 100.0);
            Assert.AreEqual(2, dicountProduct.Price); //because 4.00/2 = 2.00
        }
    }
}
