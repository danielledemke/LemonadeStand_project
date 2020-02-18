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
        public bool didPurchase;

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
            
            int randomInt = random.Next(1, 5);
            return randomInt;
        }

        public void GetPriceWillingToPay(Weather weather, Random random)
        {
            int number = GetRandom(random);

            if(number == 1)
            {
                priceWillingToPay = .30;
            }
            else if(number == 2)
            {
                priceWillingToPay = .25;
            }
            else if(number == 3 || weather.temperature >= 80)
            {
                priceWillingToPay = .50;
            }
            else if(number == 4 || weather.temperature <= 50)
            {
                priceWillingToPay = .15;
            }
        }

        public void DecideToPurchase(Player player, Weather weather, Random random, Pitcher pitcher)
        {
            
            GetPriceWillingToPay(weather, random);
            if(priceWillingToPay >= player.recipe.pricePerCup && player.recipe.pricePerCup < customerMoney && pitcher.cupsLeftInPitcher > 0)
            {
                PurchaseLemonadeFromPlayer(player, pitcher);
                
            }
           
            
        }
        public void PurchaseLemonadeFromPlayer(Player player, Pitcher pitcher)
        {

            {
                customerMoney -= player.recipe.pricePerCup;
                player.wallet.Money += player.recipe.pricePerCup;
                pitcher.cupsLeftInPitcher--;
                didPurchase = true;

                Console.WriteLine(name + " has decided to purchase cup of lemonade!");
            }
        }
            
    }
}
