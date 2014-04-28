using System;
using DesignPatternsLibrary.CompositePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.CompositePattern
{
    [TestClass]
    public class SimpleProductTest
    {
        [TestMethod]
        public void CreateSimpleProduct()
        {
            IProduct simpleProduct = new SimpleProduct("Iogurte", 2.40);
            Assert.AreEqual("Iogurte", simpleProduct.Name);
            Assert.AreEqual(2.40, simpleProduct.Price);
        }
    }
}
