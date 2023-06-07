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
        
        public List<Day> Days { get { return days; } }
        //Constructor- Remember to spawn your new variables. 
        public Game()
        {
            days = new List<Day>();
            currentDay = 0;
            weather = new Weather();

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

        public void RunGame()
        {
            UserInterface.DisplayWelcome(); //Working
            //Create Store to buy supplies
                //Display Inventory
                //Sell Supplies to Player
            weather.WeeklyForcast(); //Working but with an issue of duplicated keys.


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
