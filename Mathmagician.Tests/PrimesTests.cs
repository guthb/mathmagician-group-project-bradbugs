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
        public void PrimesIsPrimeReturnsTrueForKnownPrimes()
        {
            //Arrange
                //This is a list of known primes:
                // 11, 17, 41, 953, 715225739

            //Act
            //Assert
            Assert.IsTrue(Primes.isPrime(11));
            Assert.IsTrue(Primes.isPrime(17));
            Assert.IsTrue(Primes.isPrime(41));
            Assert.IsTrue(Primes.isPrime(953));
            Assert.IsTrue(Primes.isPrime(715225739));
        }

        [TestMethod]
        public void PrimesIsPrimeReturnFalseForKnownUnprimes()
        {
            //Arrange
                //This is a list of known unprimes:
                // 4, 8, 235, 4678, 90210
            //Act
            //Assert
            Assert.IsFalse(Primes.isPrime(4));
            Assert.IsFalse(Primes.isPrime(8));
            Assert.IsFalse(Primes.isPrime(235));
            Assert.IsFalse(Primes.isPrime(4678));
            Assert.IsFalse(Primes.isPrime(90210));
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
