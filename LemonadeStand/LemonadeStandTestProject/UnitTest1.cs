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
        public void Inventory_AddSugar()
        {
            //Arrange
            int amount = 10;
            int result;
            Inventory inventory = new Inventory();
            inventory.AddSugar(amount);
            //Act
            result = 10;
            //Assert
            Assert.AreEqual(result, inventory.Sugar);
        }

        [TestMethod]
        public void Inventory_RemoveSugar()
        {
            //Arrange
            Inventory inventory = new Inventory();
            inventory.AddSugar(20);
            int amount = 20;
            int result;
            inventory.RemoveSugar(amount);
            //Act
            result = 0;
            //Assert
            Assert.AreEqual(result, inventory.Sugar);
        }

        [TestMethod]
        public void Inventory_RemoveCups_False()
        {
            //Arrange
            Inventory inventory = new Inventory();
            inventory.AddCups(5);
            int amount = 7;
            bool result;
            inventory.RemoveCups(amount);
            //Act
            result = false;
            //Assert
            Assert.AreEqual(result, inventory.RemoveCups(amount));
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
        public void Store_CalculateRunningProfitLoss_Over500()
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
        public void Store_CalculateRunningProfitLoss_LessThan500()
        {
            //Arrange
            Random random = new Random();
            Player player = new Player("hank", random);
            Store store = new Store(random, player);
            double dailySales = 100;
            store.Money = 300;
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
        public void Weather_GetSkyCover()
        {
            //Arrange
            Random random = new Random();
            Weather weather = new Weather(random);
            string skyCover = "sunny";
            //Act
            weather.GetSkyCover();
            //Assert
            Assert.AreEqual(skyCover, weather.SkyCover);
        }

        [TestMethod]
        public void Weather_GetTemperature()
        {
            //Arrange
            Random random = new Random();
            Weather weather = new Weather(random);
            string temperature = "hot";
            //Act
            weather.GetTemperature();
            //Assert
            Assert.AreEqual(temperature, weather.Temperature);
        }

        [TestMethod]
        public void Day_SetPotentialCustomers()
        {
            //Arrange
            Random random = new Random();
            Day day = new Day(random);
            Weather weather = new Weather(random);
            weather.LemonadeDemand = "high";
            int result = 151;
            //Act
            day.SetPotentialCustomers();
            //Assert
            Assert.AreEqual(result, day.PotentialCustomers.Count);
        }
    }
}
