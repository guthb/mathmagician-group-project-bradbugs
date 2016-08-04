using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        //test for class validation
        public void IntegerEnsureICanCreateAnInstance()
        {

            //Arrange
            
            //Act
            Integer my_int = new Integer();

            //Assert
            Assert.IsNotNull(my_int);

        }

        [TestMethod]
        //test for list 
        public void IntegerEnsureOutputIsAList()
        { 
            
            //Arange


            //Act
            Integer myList = new Integer();


            //Assert
            Assert.IsInstanceOfType(myList.ListIntegers(0), typeof(List<int>));

        }

        [TestMethod]
        //test for list of integers
        public void IntegerEnsureOutputIsAListestIntegers()
        {
            //Arange


            //Act
            Integer integerList = new Integer();

            List<int> testList = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8 };


            //Assert
            CollectionAssert.AreEqual(testList, integerList.ListIntegers(8));


        }



    }
}
