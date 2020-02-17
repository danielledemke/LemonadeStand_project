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
            PlayOneFullDay();
            
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
            Store store = new Store();

            store.SellLemons(player);
            store.SellIceCubes(player);
            store.SellSugarCubes(player);
            store.SellCups(player);
            player.ChooseRecipe();
            day.DisplayAmountOfCustomers();
            day.GetCustomersToDecide(player, day.weather, random);
            Console.ReadLine();
        }
        
    }
}
