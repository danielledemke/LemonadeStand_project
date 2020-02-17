using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //member variables
        private double customerMoney;
        private double priceWillingToPay;
        public string name;
        public static int nameNumber;

        //constructor
        public Customer()
        {
            customerMoney = 10;
            nameNumber++;
            name = "Customer " + nameNumber;

            
        }

        //member methods

        public int GetRandom(Random random)
        {
            
            int randomInt = random.Next(1, 4);
            return randomInt;
        }

        public void GetPriceWillingToPay(Weather weather, Random random)
        {
            int number = GetRandom(random);

            if(number == 1)
            {
                priceWillingToPay = .25;
            }
            else if(number == 2)
            {
                priceWillingToPay = .35;
            }
            else if(number == 3 || weather.temperature >= 80)
            {
                priceWillingToPay = .50;
            }
        }

        public void DecideToPurchase(Player player, Weather weather, Random random)
        {
            
            GetPriceWillingToPay(weather, random);
            if(priceWillingToPay >= player.recipe.pricePerCup && player.recipe.pricePerCup < customerMoney)
            {
                PurchaseLemonadeFromPlayer(player);
                Console.WriteLine(name + " has decided to purchase cup of lemonade!");
            }
            
        }
        public void PurchaseLemonadeFromPlayer(Player player)
        {
            customerMoney -= player.recipe.pricePerCup;
            player.wallet.Money += player.recipe.pricePerCup;
        }
    }
}
