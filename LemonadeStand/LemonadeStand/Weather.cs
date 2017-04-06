using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        private string skyCover;
        private string temperature;
        private string lemonadeDemand;
        private Random random;

        public string SkyCover { get { return skyCover; } }
        public string Temperature { get { return temperature; } }
        public string LemonadeDemand { get { return lemonadeDemand; } }

        public Weather(Random Random)
        {
            random = Random;
            GetWeather();
        }

        public void GetWeather()
        {
            GetSkyCover();
            GetTemperature();
            DetermineLemonadeDemand(skyCover, temperature);
            DisplayWeather();
        }

        public void DisplayWeather()
        {
            Console.WriteLine("Today's Weather: ");
            Console.WriteLine("> Skycover: " + skyCover);
            Console.WriteLine("> Temperature: " + temperature);
            Console.WriteLine();

        }

        public string GetSkyCover()
        {
            int randomSkyCover = random.Next(11);

            if(randomSkyCover >= 0 && randomSkyCover <= 5)
            {
                skyCover = "sunny";
            }else if(randomSkyCover >= 6 && randomSkyCover <= 8)
            {
                skyCover = "overcast";
            }else
            {
                skyCover = "rainy";
            }
            return skyCover;
        }

        public string GetTemperature()
        {
            int randomTemperature = random.Next(11);

            if (randomTemperature >= 0 && randomTemperature <= 2)
            {
                temperature = "hot";
            }
            else if (randomTemperature >= 6 && randomTemperature <= 8)
            {
                temperature = "comfortable";
            }
            else
            {
                temperature = "cold";
            }
            return temperature;
        }

        public string DetermineLemonadeDemand(string skyCover, string temperature)
        {
            if(skyCover == "sunny" && temperature == "cold")
            {
                lemonadeDemand = "medium";
            }else if(skyCover == "sunny" && temperature == "comfortable")
            {
                lemonadeDemand = "high";
            }
            else if (skyCover == "sunny" && temperature == "hot")
            {
                lemonadeDemand = "very high";
            }
            else if (skyCover == "overcast" && temperature == "cold")
            {
                lemonadeDemand = "low";
            }
            else if (skyCover == "overcast" && temperature == "comfortable")
            {
                lemonadeDemand = "medium";
            }
            else if (skyCover == "overcast" && temperature == "hot")
            {
                lemonadeDemand = "high";
            }
            else if (skyCover == "rainy")
            {
                lemonadeDemand = "low";
            }
            return lemonadeDemand;
        }
    }
}
