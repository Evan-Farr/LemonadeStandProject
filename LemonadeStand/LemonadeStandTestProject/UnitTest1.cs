using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Inventory_AddLemons()
        {
            //Arrange
            int amount = 3;
            int result;
            Inventory inventory = new Inventory();
            inventory.AddLemon(amount);
            //Act
            result = 3;
            //Assert
            Assert.AreEqual(inventory.Lemons, result);
        }

        [TestMethod]
        public void Inventory_RemoveLemons()
        {
            //Arrange
            Inventory inventory = new Inventory();
            inventory.AddLemon(3);
            int amount = 3;
            int result;
            inventory.RemoveLemons(amount);
            //Act
            result = 0;
            //Assert
            Assert.AreEqual(inventory.Lemons, result);
        }
    }
}
