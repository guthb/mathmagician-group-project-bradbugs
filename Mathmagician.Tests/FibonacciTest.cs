using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    class FibonacciTest
    {   //the sum of the two preceding numbers in a sequence
        [TestMethod]
        //test that the class can be created
        public void FibonacciEnsureICanCreateAnInstance()
        {
            // Arrange


            //Act
            Fibonacci my_fibo = new Fibonacci();

            //Assert
            Assert.IsNotNull(my_fibo);
        }

        [TestMethod]
       //Test the list that the numbers are added coorectly
        public void FibonacciListAddtionTest()
        {

            // Arrange


            //Act
            Fibonacci fiboList = new Fibonacci();
            List<int> testList = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21 };


            //Assert
            CollectionAssert.AreEqual(testList, Fibonacci.);





        }





    }
}
