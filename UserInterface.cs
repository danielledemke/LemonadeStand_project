using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }
        public static void DisplayGameRules()
        {
            Console.WriteLine("Welcome to the game of Lemonade Stand! You made a good choice when you decided to play.");
            Console.WriteLine("How To Play:\n");
            Console.WriteLine("Your lemonade stand will be open for 7 days. At the beginning of each day, you will get to see the weather forecast and purchase amount of ingredients based on what you think the demand will be!");
            Console.WriteLine("After buying ingredients, you will set your recipe for each day to specify how much of an item goes into each pitcher you make.");
            Console.WriteLine("Based on weather conditions and price of your lemonade, customers will decide whether they want to buy or not.");
            Console.WriteLine("Press enter when you are ready to start the challenge -- and good luck!");
            Console.ReadLine();
        }


    }
}
