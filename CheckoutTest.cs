using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckOutSystem;

namespace CheckOutSystemTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod()]
        public void Test_Apple_Amount_into_List()
        {

            //Arrange
            int expected = 2;
            int actual;
            int appleAmount = 2;
            Product prodTest = new Product();

            //Act
            prodTest.AddApple(appleAmount);
            actual = prodTest.NumOfItems();

            //Assert    
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod()]
        public void Test_Orange_Amount_into_List()
        {
            int expected = 1;
            int actual;
            int orangeAmount = 1;
            Product prodTest = new Product();

            //Act
            prodTest.AddOrange(orangeAmount);
            actual = prodTest.NumOfItems();

            //Assert    
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod()]
        public void Test_Total_Amount_Of_Items_In_Basket()
        {
            //Arrange
            int actual;
            int expected = 3;
            int appleAmount = 2;
            int orangeAmount = 1;
            Product prodTest = new Product();

            //Act
            prodTest.AddApple(appleAmount);
            prodTest.AddOrange(orangeAmount);
            actual = prodTest.NumOfItems();

            //Assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod()]
        public void Test_If_Basket_Is_Empty()
        {
            //Arrange
            Product prodTest = new Product();

            int actual;
            int expectedBasketCount = 0;
            int appleAmount = 2;
            int orangeAmount = 1;

            //Act
            prodTest.AddApple(appleAmount);
            prodTest.AddOrange(orangeAmount);
            prodTest.EmptyBasket();
            actual = prodTest.NumOfItems();

            //Assert
            Assert.AreEqual<int>(expectedBasketCount, actual);
        }

    }

    [TestClass]
    public class CheckOutSysTest
    {
        [TestMethod]
        public void Test_Till_For_Total_Amount()
        {
            // Arrange
            double expected = 1.35;
            double actual;
            int appleAmount = 1;
            int orangeAmount = 3;

            Product prodTest = new Product();
            CheckOutSys checkout = new CheckOutSys();

            //Act
            prodTest.AddApple(appleAmount);
            prodTest.AddOrange(orangeAmount);
            checkout.Till(prodTest.GetBasket());
            actual = checkout.ReturnTotal();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
