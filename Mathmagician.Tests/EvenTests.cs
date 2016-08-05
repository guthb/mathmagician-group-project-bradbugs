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

        [TestMethod]
        public void EvensListEvensOutputs13EarlyEvens()
        {
            //Arrange
            Even my_even = new Even();
            List<int> my_list = new List<int>() { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24 };
            //Act
            //Assert
            CollectionAssert.AreEqual(my_list, my_even.ReturnEvenNumbersList(13));
            
        }
    }
}
