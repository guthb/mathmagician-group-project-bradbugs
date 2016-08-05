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


        public int fibotest(int a, int b)
        {

            int temp = a;
            a = b;
            b = temp + b;
            return b;
        }

        [TestMethod]

        public void FibonacciSequeceTest()
        {

            // Arrange
            Fibonacci fiboListSequence = new Fibonacci();

            //Act

            //known fibo pairs


            //8 = 5+3

            //13 = 8+5

            //55 = 34+21

            //144 = 89+55

            //317811  121393 + 196418


            //Assert
            Assert.AreEqual(fibotest(5,3), 8);
            Assert.AreEqual(fibotest(8,5), 13);
            Assert.AreEqual(fibotest(34,21), 55);
            Assert.AreEqual(fibotest(89, 55), 144);
            Assert.AreEqual(fibotest(196418, 121393), 317811);
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
