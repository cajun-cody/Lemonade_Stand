using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player : Game
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            name = "Player One";
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        // member methods (CAN DO)

        //Adjust recipe. 


        //Make pitchers and remove items from inventory.
        //Need to have variables for each recipe item. Calculate how many are needed per pitcher. 
        public int MakePitcher()
        {
            //Get amount of pitchers to sell. Each pitcher makes 8 cups
            int pitchers = UserInterface.GetNumberOfPitchers();

            int lemonsOut = pitchers * recipe.numberOfLemons;
            int sugerCubesOut = pitchers * recipe.numberOfSugarCubes;
            int iceCubesOut = pitchers *recipe.numberOfIceCubes;
            int cupsOut = pitchers * 8;
            //Need to remove items from inventory. 
            //Need conditional to check if inventory can cover the amount of pitchers to be made. 
            if (lemonsOut < inventory.lemons.Count && sugerCubesOut < inventory.sugarCubes.Count && iceCubesOut < inventory.iceCubes.Count && cupsOut < inventory.cups.Count)
            {
                //Use Remove range to take out a series of lemons not just at the index when using RemoveAt.
                inventory.lemons.RemoveRange(0, lemonsOut);
                inventory.sugarCubes.RemoveRange(0, sugerCubesOut);
                inventory.iceCubes.RemoveRange(0, iceCubesOut);
                inventory.cups.RemoveRange(0, cupsOut);
                return pitchers;
            }
            else
            {
                Console.WriteLine("\nYou don't have enough product to make that many pitchers. You need to go shopping.\n");
                GoShopping();
                MakePitcher();
            }


            return pitchers;
        }
 
    }
}
