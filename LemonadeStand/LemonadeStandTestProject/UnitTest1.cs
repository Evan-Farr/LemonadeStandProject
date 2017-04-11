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
            Assert.AreEqual(result, inventory.Lemons);
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
            Assert.AreEqual(result, inventory.Lemons);
        }

        [TestMethod]
        public void Weather_DetermineDemand()
        {
            //Arrange
            Random random = new Random();
            Weather weather = new Weather(random);
            string skyCover = "overcast";
            string temperature = "cold";
            string result = "low";
            //Act
            weather.DetermineDemand(skyCover, temperature);
            //Assert
            Assert.AreEqual(result, weather.LemonadeDemand);
        }

        [TestMethod]
        public void Store_CalculateRunningProfitLoss()
        {
            //Arrange
            Random random = new Random();
            Player player = new Player("hank", random);
            Store store = new Store(random, player);
            double dailySales = 100;
            store.Money = 600;
            double result = 200; 
            //Act
            store.CalculateRunningProfitLoss(dailySales);
            //Assert
            Assert.AreEqual(result, store.RunningProfitLoss);
        }

        [TestMethod]
        public void Store_UpdateMoney()
        {
            //Arrange
            Random random = new Random();
            Player player = new Player("hank", random);
            Store store = new Store(random, player);
            double sales = 100;
            store.Money = 600;
            double result = 700;
            //Act
            store.UpdateMoney(sales);
            //Assert
            Assert.AreEqual(result, store.Money);
        }

        [TestMethod]
        public void Store_CalculateDailyProfitLoss()
        {
            //Arrange
            Random random = new Random();
            Player player = new Player("hank", random);
            Store store = new Store(random, player);
            double dailySales = 300;
            store.DailyExpenses = 100;
            double result = 200;
            //Act
            store.CalculateDailyProfitLoss(dailySales);
            //Assert
            Assert.AreEqual(result, store.DailyProfitLoss);
        }

        [TestMethod]
        public void ()
        {
            //Arrange
            
            //Act
            
            //Assert
            Assert.
        }
    }
}
