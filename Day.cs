using System;
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
        public int numberOfSales;

        //constructor
        public Day()
        {
            
            weather = new Weather();
            SetAmountOfCustomers();
            
        }

        //member methods
        public void SetAmountOfCustomers()
        {
            
            if(weather.condition == "Sunny" && weather.temperature >= 70)
            {
                customers = new List<Customer>();
                for(int i = 0; i < 60; i++)
                {
                    customers.Add(new Customer());
                    
                }
            }
            if (weather.condition == "Cloudy" && weather.temperature >= 70)
            {
                customers = new List<Customer>();
                for (int i = 0; i < 45; i++)
                {
                    customers.Add(new Customer());
                }
            }
            if (weather.condition == "Sunny" && weather.temperature < 70)
            {
                customers = new List<Customer>();
                for (int i = 0; i < 50; i++)
                {
                    customers.Add(new Customer());
                }
            }
            if (weather.condition == "Cloudy" && weather.temperature < 70)
            {
                customers = new List<Customer>();
                for (int i = 0; i < 35; i++)
                {
                    customers.Add(new Customer());
                }
            }
            if(weather.condition == "Rainy" && weather.temperature >= 70)
            {
                customers = new List<Customer>();
                for (int i = 0; i < 25; i++)
                {
                    customers.Add(new Customer());
                }
            }
            if (weather.condition == "Rainy" && weather.temperature < 70)
            {
                customers = new List<Customer>();
                for (int i = 0; i < 20; i++)
                {
                    customers.Add(new Customer());
                }
            }

        }

        public void DisplayAmountOfCustomers()
        {
            Console.WriteLine("There are " + customers.Count + " potential customers outside today!");
            Console.WriteLine("Press enter when you are ready to see who purchases lemonade!");
            Console.ReadLine();
        }

        public void GetCustomersToDecide(Player player, Weather weather, Random random, Pitcher pitcher)
        {
                foreach(Customer customer in customers)
                {
                 player.KeepLemonadeStocked();
                 customer.DecideToPurchase(player, weather, random, pitcher);
                    
                }
                if(pitcher.cupsLeftInPitcher == 0)
            {
                Console.WriteLine("You ran out of lemonade to sell!"); 
            }
        }

    }
}
