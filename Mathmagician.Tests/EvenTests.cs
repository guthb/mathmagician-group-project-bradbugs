using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EvenAreAbleToBeInstantiated()
        {
            //Arrange
            //Act
            Even my_even = new Even();
            //Assert
            Assert.IsNotNull(my_even);
        }

        [TestMethod]
        public void EvenListEvensReturnsAList()
        {
            //Arrange
            Even my_even = new Even();
            //Act
            //Assert
            Assert.IsInstanceOfType(my_even.ReturnEvenNumbersList(0), typeof(List<int>));
        }
    }
}
