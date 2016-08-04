using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimesTests
    {
        [TestMethod]
        public void PrimesAreAbleToBeInstantiated()
        {
            //Arrange
            //Act
            Primes my_prime = new Primes();
            //Assert
            Assert.IsNotNull(my_prime);
        }

        [TestMethod]
        public void PrimesListPrimesReturnsAList()
        {
            //Arrange
            Primes my_prime = new Primes();
            List<int> my_list = new List<int>();
            //Act
            //Assert
            Assert.AreEqual(my_prime.ReturnPrimeNumbersList(0).GetType(), my_list.GetType());
        }

        [TestMethod]
        public void PrimesListPrimesOutputs13EarlyPrimes()
        {
            //Arrange
            Primes my_prime = new Primes();
            List<int> my_list = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41 };
            //Act
            //Assert
            CollectionAssert.AreEqual(my_list, my_prime.ReturnPrimeNumbersList(13));
        }
    }
}
