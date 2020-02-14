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
        private int currentDay;
        

        //constructor
        public Game()
        {
            Player player = new Player();
            Day day = new Day();
            Console.WriteLine("The weather is currently " + day.weather.condition + " with a temperature of " + day.weather.temperature + " degrees");
            Console.ReadLine();
        }

        //member methods
        public void ShowGameRules()
        {

        }


    }
}
