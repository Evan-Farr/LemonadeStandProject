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
        private int temperature;
        private string lemonadeDemand;

        public Weather()
        {
            GetWeather();
        }

        public void GetWeather()
        {
            GetSkyCover();
            GetTemperature();
            DetermineLemonadeDemand(skyCover, temperature);
        }

        public void DisplayWeather()
        {
            Console.WriteLine("Weather Forcast: ");
            Console.WriteLine("> Skycover: " + skyCover);
            Console.WriteLine("> Temperature: " + temperature);
            Console.WriteLine("> Predicted Demand for Lemonade: " + lemonadeDemand);

        }

        public string GetSkyCover()
        {
            Random random = new Random();
            int option = random.Next(11);

            if(option == 0 && option == 1 && option == 2 && option == 3 && option == 4 && option == 5)
            {
                skyCover = "sunny";
            }else if(option == 6 && option == 7 && option == 8)
            {
                skyCover = "overcast";
            }else
            {
                skyCover = "rainy";
            }
            return skyCover;
        }

        public int GetTemperature()
        {
            Random random = new Random();
            temperature = random.Next(65, 102);
            return temperature;
        }

        public string DetermineLemonadeDemand(string skyCover, int temperature)
        {
            if(skyCover == "sunny" && temperature >= 65 && temperature <= 74)
            {
                lemonadeDemand = "low";
            }else if(skyCover == "sunny" && temperature >= 75 && temperature <= 90)
            {
                lemonadeDemand = "high";
            }
            else if (skyCover == "sunny" && temperature >= 91 && temperature <= 102)
            {
                lemonadeDemand = "very high";
            }
            else if (skyCover == "overcast" && temperature >= 65 && temperature <= 74)
            {
                lemonadeDemand = "low";
            }
            else if (skyCover == "overcast" && temperature >= 75 && temperature <= 90)
            {
                lemonadeDemand = "medium";
            }
            else if (skyCover == "overcast" && temperature >= 91 && temperature <= 102)
            {
                lemonadeDemand = "high";
            }
            else if (skyCover == "rainy" && temperature >= 65 && temperature <= 102)
            {
                lemonadeDemand = "low";
            }
            return lemonadeDemand;
        }

        public string SkyCover { get { return skyCover; } }
        
        public int Temperature { get { return temperature; } }

        public string LemonadeDemand { get { return lemonadeDemand; } }
        
    }
}
