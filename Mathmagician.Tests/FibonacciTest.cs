using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonacciTest
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
        //test
        public void FibonacciEnsureIcanCreateAList()
        {
            // Arrange
            Fibonacci my_fibo_list = new Fibonacci();
            List<int> testList = new List<int>();

            //Act


            //Assert
            Assert.IsInstanceOfType(my_fibo_list.ReturnFibonacciSequence(0), typeof(List<int>));

        }

        [TestMethod]
        public void FibonacciEnsureListCount()
        {
            // Arrange
            Fibonacci my_fibo_List = new Fibonacci();
            List<int> testListCount = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21 };

            //Act


            //Assert
            Assert.AreEqual(testListCount.Count, my_fibo_List.ReturnFibonacciSequence(8).Count);

        }

        [TestMethod]
        //Test the list that the numbers are added correctly
        public void FibonacciOutputTest()
        {

            // Arrange
            Fibonacci fiboList = new Fibonacci();
            List<int> testList = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21 };

            //Act
            
            //Assert
            CollectionAssert.AreEqual(testList, fiboList.ReturnFibonacciSequence(8));

        }





    }
}
