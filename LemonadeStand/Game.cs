using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
        public Random random;
        
        //public List<Day> Days { get { return days; } }
        //Constructor- Remember to spawn your new variables. 
        public Game()
        {
            days = new List<Day>();
            currentDay = 0;
            //weather = new Weather();
            //player = new Player();
            store = new Store();
            random = new Random();
        }

        //Member Methods

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
            weather = new Weather();
            weather.WeeklyForcast(); //Working 
            //Create Store, show inventory and buy supplies. 
            player = new Player();
            //Variable to hold the sum of the daily income for the durration of the game. 
            double totalIncome = 0;

            //While Loop to run game each day with max of 7.
            while (currentDay < 2)
            {
                if (player.wallet.Money > 0) //Need a way to exit the loop. Finish game or go broke.
                {
                //Create a day - Calulate Customers and % sales due to weather. 
                days.Add(new Day());
                //Create what the day looks like. 
                Console.WriteLine($"\nIt's day {currentDay +1}. Let's Push some units!\n");              
                //Todays inventory and recipe with option to GoShopping
                player.inventory.DisplayCurrentInventory();
                player.recipe.DisplayRecipe();
                Console.WriteLine($"You have {player.wallet.Money} dollars in your wallet.");
                //Allow player to change recipe?? Come back to this. 

                Console.WriteLine("Do you want to purchase more items? Y/N ");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    GoShopping();
                }
                //Make lemonade to sell. Need to convert if not enough product we go shopping. 
                int pitchersToSell = player.MakePitcher();
                    if (pitchersToSell == 0)
                    {
                        GoShopping();
                        pitchersToSell = player.MakePitcher();
                    }
                //Convert pitchers to sell to cups. 
                int cupsToSell = pitchersToSell * 8;
                //Get user to set price of each cup. 
                Console.WriteLine("How much do you want to charge for a cup? (.50 or 1 or 1.25)");
                player.recipe.price = double.Parse(Console.ReadLine());
                //This will get todays weather as well as amount of customers that will buy lemonade.
                 days[currentDay].RunStand(player);
                 days[currentDay].DailySales(cupsToSell, player.recipe.price);
                    double dailyIncome = days[currentDay].dailyIncome;
                    player.wallet.AcceptMoney(dailyIncome);
                    totalIncome += dailyIncome;


                    currentDay++;
                }
                else
                {
                    Console.WriteLine("Well looks like you went broke. Better luck next time.");
                }


            }
            //Display end of game message. 
            Console.WriteLine("Check out what you made. Thanks for playing!");
            Console.WriteLine($"Total income: ${totalIncome}");
        }

    }
}
