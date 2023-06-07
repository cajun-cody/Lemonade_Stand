using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            name = "Lemonade Vendor";
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        // member methods (CAN DO)

        //Purchase Lemons
        //Need a variable to hold an int for how many lemons a player wants to buy. Use a userinput to get this value.
        public int lemonsNeeded = UserInterface.GetNumberOfItems("lemons");
            //Need to pay money for items to the store. 
            //Store needs to accept payment with a check to see if i have enough money. Store functions have this built in. 
            //Need to add my items to my inventory. 

        //Purchase Sugar Cubes

        //Purchase IceCubes

        //Purchase Cups
    }
}
