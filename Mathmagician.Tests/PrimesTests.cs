using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimesTests
    {
        [TestMethod]
        public void PrimesEnsureICanCreateAnInstance()
        {
            //Arrange
            Primes myPrime = new Primes();

            //Act

            //Assert
            Assert.IsNotNull(myPrime);
        }

        [TestMethod]
        public void PrimesListPrimesMethodReturnsAList()
        {
            //Arrange
            Primes myPrime = new Primes();

            //Act

            //Assert
            Assert.IsInstanceOfType(myPrime.ListPrimes(2), typeof(List<int>));
        }

        [TestMethod]
        public void PrimesListPrimesMethodCorrelatesToEarlyPrimes()
        {
            //Arrange
            List<int> testOfEarlyPrimes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19 };

            //Act
            Primes myPrime = new Primes();

            //Assere
            CollectionAssert.AreEqual(testOfEarlyPrimes, myPrime.ListPrimes(8));

        }
    }
}
