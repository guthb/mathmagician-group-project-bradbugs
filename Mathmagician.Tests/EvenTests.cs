using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EvensAreAbleToBeInstantiated()
        {
            Even my_even = new Even();
            Assert.IsNotNull(my_even);
        }
    }
}
