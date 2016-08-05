using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class OddsTest
    {
        [TestMethod]
        //test for class creation
        public void OddEnsureICanCreateAnInstance()
        {
                //Arrange

                //Act
                Odds my_odd = new Odds();

                //Assert
                Assert.IsNotNull(my_odd);
        
        }

        [TestMethod]
        //test for list of integers
        public void OddEnsureICanCreateAList()
        {
            //Arrange

            //Act
            Odds my_odd_list = new Odds();

            //Assert
            Assert.IsInstanceOfType(my_odd_list.ListOdds(0), typeof(List<int>));

        }

        [TestMethod]
        //test for odd list of integers
        public void OddEnsureListOfOddIntegers()
        {

            //Arrange

            //Act
            Odds my_odd_list_integers = new Odds();
            List<int> testList = new List<int>() { 1, 3, 5, 7, 9, 11, 13};

            //Assert
            CollectionAssert.AreEqual(testList,my_odd_list_integers.ListOdds(7));



        }
        






    }
}
