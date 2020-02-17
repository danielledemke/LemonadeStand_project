using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //member variables
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public Random random;
        

        //constructor
        public Weather()
        {
            
            weatherConditions = new List<string>();
            weatherConditions.Add("Sunny");
            weatherConditions.Add("Cloudy");
            weatherConditions.Add("Rainy");
            GenerateRandomWeatherCondition();
            temperature = SetRandomTemperature();
        }

        //member methods
        private void GenerateRandomWeatherCondition()
        {
            int weatherNumber = GetRandomNumber();
            if(weatherNumber == 1)
            {
                condition = "Sunny";
            }
            if (weatherNumber == 2)
            {
                condition = "Cloudy";
            }
            if (weatherNumber == 3)
            {
                condition = "Rainy";
            }
           
        }
        private int SetRandomTemperature()
        {
            random = new Random();
            int temperatureNumber = random.Next(50, 90);
            return temperatureNumber;
        }

        private int GetRandomNumber()
        {
            random = new Random();
            int result = random.Next(1, 4);
            return result;
        }




    }
}
