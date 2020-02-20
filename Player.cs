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
            pitcher = new Pitcher();
        }

        // member methods (CAN DO)
        public void ChooseRecipe()
        {
            recipe = new Recipe();
            Console.WriteLine("You can now create your recipe.");
            Console.WriteLine("How many lemons per pitcher would you like to use?");
            recipe.amountOfLemons = int.Parse(Console.ReadLine());
            Console.WriteLine("How many sugar cubes per pitcher would you like to use?");
            recipe.amountOfSugarCubes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes per pitcher would you like to use?");
            recipe.amountOfIceCubes = int.Parse(Console.ReadLine());
            Console.WriteLine("How much would you like to charge per cup?");
            recipe.pricePerCup = double.Parse(Console.ReadLine());

        }
        
        public void MakePitcher()
        {
            
            {
                pitcher.cupsLeftInPitcher = 10;
                inventory.lemons.RemoveRange(0,recipe.amountOfLemons);
                inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);
                inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
                inventory.cups.RemoveRange(0, 10);
                Console.WriteLine("You have made a pitcher of lemonade");
            }
           
        }
        

        public void KeepLemonadeStocked()
        {
            bool isValid = true;
            while (isValid)
            {
                if (pitcher.cupsLeftInPitcher == 0)
                {
                    CheckInventoryAmount();
                    
                    isValid = false;
                }
                else
                {
                    isValid = false;
                }
            }
            
        }
        public void CheckInventoryAmount()
        {
            //Here I used Singular Responsibility to break down this method to only do one thing. Originally, I had my game checking inventory levels inside of another method
            if (inventory.lemons.Count >= recipe.amountOfLemons && inventory.sugarCubes.Count >= recipe.amountOfSugarCubes && inventory.iceCubes.Count >= recipe.amountOfIceCubes && inventory.cups.Count >= 10)
            {
                MakePitcher();
            }
            
        }
    }
}
