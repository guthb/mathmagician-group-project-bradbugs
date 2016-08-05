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

    }
}
