﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //member variables
        public Weather weather;
        public List<Customer> customers;

        //constructor
        public Day()
        {
            weather = new Weather();
            SetAmountOfCustomers();
        }

        //member methods
        public void SetAmountOfCustomers()
        {
            
            if(weather.condition == "Sunny" && weather.temperature > 70)
            {
                customers = new List<Customer>();
                for(int i = 0; i < 40; i++)
                {
                    customers.Add(new Customer());
                }
            }
            if (weather.condition == "Cloudy" && weather.temperature > 70)
            {
                customers = new List<Customer>();
                for (int i = 0; i < 30; i++)
                {
                    customers.Add(new Customer());
                }
            }
            if (weather.condition == "Sunny" && weather.temperature < 70)
            {
                customers = new List<Customer>();
                for (int i = 0; i < 35; i++)
                {
                    customers.Add(new Customer());
                }
            }
            if (weather.condition == "Cloudy" && weather.temperature < 70)
            {
                customers = new List<Customer>();
                for (int i = 0; i < 25; i++)
                {
                    customers.Add(new Customer());
                }
            }
            if(weather.condition == "Rainy" && weather.temperature > 70)
            {
                customers = new List<Customer>();
                for (int i = 0; i < 20; i++)
                {
                    customers.Add(new Customer());
                }
            }
            if (weather.condition == "Rainy" && weather.temperature < 70)
            {
                customers = new List<Customer>();
                for (int i = 0; i < 15; i++)
                {
                    customers.Add(new Customer());
                }
            }

        }

    }
}
