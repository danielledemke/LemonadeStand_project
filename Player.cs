using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public string name;
        public Recipe recipe;
        public Pitcher pitcher;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            SetUserName();
        }

        // member methods (CAN DO)
        public void ChooseRecipe()
        {
            recipe = new Recipe();
            Console.WriteLine("How many lemons per pitcher would you like to use?");
      //      recipe.amountOfLemons = Console.ReadLine();
            Console.WriteLine("How many sugar cubes per pitcher would you like to use?");
     //       recipe.amountOfLemons = Console.ReadLine();
      //      Console.WriteLine("How many ice cubes per cup would you like to use?");
      //      recipe.amountOfIceCubes = Console.ReadLine();
       //     Console.WriteLine("How much would you like to charge per cup?");
      //      recipe.pricePerCup = Console.ReadLine();

        }

        public void SetUserName()
        {
            Console.WriteLine("Please enter name for your player: \n");
            name = Console.ReadLine();
        }

    }
}
