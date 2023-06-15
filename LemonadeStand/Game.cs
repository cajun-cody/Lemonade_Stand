using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        //Member Variables- Add new variables as classes that need to be called. 
        private Player player;
        private List<Day> days;
        private int currentDay;
        private Weather weather;
        public Store store;
        
        public List<Day> Days { get { return days; } }
        //Constructor- Remember to spawn your new variables. 
        public Game()
        {
            days = new List<Day>();
            currentDay = 0;
            weather = new Weather();
            player = new Player();
            store = new Store();
            
            

        }

        //Member Methods

        //Create Current Day--Do I need this?
        public void CreateCurrentDay(int numDay)
        {
            for (int i = 0; i < numDay; i++)
            {
                Day day = new Day();
                days.Add(day);
                Console.WriteLine($"Day {i} begins!");
            }
        }
        //Need to be able to buy product.
        public void GoShopping()
        {
            //Display Inventory
            player.inventory.DisplayCurrentInventory();
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);

        }

        public void RunGame()
        {
            UserInterface.DisplayWelcome(); //Working
            //Show weeks weather.
            weather.WeeklyForcast(); //Working but with an issue of duplicated keys.
            //Create Store, show inventory and buy supplies. 
            GoShopping();//Sell Supplies to Player and show new inventory.
            player.inventory.DisplayCurrentInventory();

            //Create what the day looks like. 


            //While Loop to run game each day with max of 7. 
            //Need a way to exit the loop. Finish game or go broke. 
                //Create a day - Calulate Customers and % sales due to weather. 
                //Display todays weather
            weather.ActualWeatherForTheDay(); //Working
                //Make pitchers of lemonade
                    //Condition for if not enough supplies go to store. 
                //Determine Price
                //Determine Customers
                //Sell lemonade
                    //Get income and add to wallet
                //Increase day count and begin again. 

            //
            

        }

    }
}
