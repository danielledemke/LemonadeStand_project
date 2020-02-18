using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //member variables
        private Player player;
        private List<Day> days;
        private static int currentDayNumber;
        public Random random;
        

        //constructor
        public Game()
        {
            player = new Player();
            random = new Random();
            RepeatDay();
            
        }

        //member methods
        public void ShowGameRules()
        {

        }

        public void PlayOneFullDay()
        {
            currentDayNumber++;
            Console.WriteLine("Welcome to Day " + currentDayNumber);
            Day day = new Day();
            Console.WriteLine("The weather for today is " + day.weather.condition + " with a temperature of " + day.weather.temperature + " degrees");
            Console.WriteLine("You currently have $" + player.wallet.Money);
            Store store = new Store();
            store.SellLemons(player);
            store.SellIceCubes(player);
            store.SellSugarCubes(player);
            store.SellCups(player);
            player.ChooseRecipe();
            
            
            day.DisplayAmountOfCustomers();
            day.GetCustomersToDecide(player, day.weather, random, player.pitcher);
            
            Console.WriteLine("After today's sales, you have a total of $" + player.wallet.Money);
            Console.ReadLine();
        }
        
        public void RepeatDay()
        {
            for(int i = 0; i < 8; i++)
            {
                PlayOneFullDay();
            }
        }
    }
}
