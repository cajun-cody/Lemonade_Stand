using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LemonadeStand
{
    internal class Day : Game
    {
        //Member Variables (Has A)
        public Weather weather;
        public List<Customer> customers;
        //public Random random;
        public int estimatedCustomers;
        public double dailyIncome;

        //Constructor
        public Day()
        {
            weather = new Weather();
            //This is a new list of customers. Not filled up yet. 
            customers = new List<Customer>();
            random = new Random();
            //this.random = random;
            estimatedCustomers = 0;
            dailyIncome = 0;
        }
        
        //Member Variables
        public void DailyPredictedWeather()
        {
            weather.ActualWeatherForTheDay();
        }

        public void RunStand(Player player)
        {
            //Actual Weather.
            DailyPredictedWeather();
            //Estimate Customers.
            //Passing in the actual price of a cup from Game class where user sets price. 
            EstimateCustomers(player.recipe.price);
            //Calculate sales depending on price. //Sales will depend on cups and price.
            //DailySales(int cupsToSell, player.recipe.price);
            
        }

        //Calculate Customers
        //Passed in price as a parameter.
        public void EstimateCustomers(double price)
        {
            //Customer estimated on daily condition
            int estimatedCustomers = 0;
            
            if (weather.predictedCondition == "Rainy")
            {
                estimatedCustomers = 10;            
            }
            else if (weather.predictedCondition == "Windy")
            {
                estimatedCustomers = 20;         
            }
            //Else carries sunny condition.
            else
            {
                estimatedCustomers = 30;
            }
            //Estimate customers from estimated customers variable to range in price. 
            //If price is above $1 random range low end else high end.
                if (price >= 1.25)
                {
                    estimatedCustomers = (int) (estimatedCustomers * 0.6);
                }
                else if (price >= .75 && price <= 1.25)
                {
                    estimatedCustomers = (int)(estimatedCustomers * 0.8);
                }
                else if (price < .75)
                {
                    estimatedCustomers = (int)(estimatedCustomers * 1.1);
                }
            
            //Loop to Create customers off of estimation depending on price. 
            for (int i = 0; i < estimatedCustomers; i++)
            {
                customers.Add(new Customer());

            }

        }

        //Calculate sales depending on if inventory of cups is sold out. Display sales at the end. 
       public double DailySales(int cupsToSell, double price)
        {
            //variable to hold total cups sold
            //variable to hold income from sales
            int cupsSold = 0;
            //double dailyIncome = 0;
           
            //Loop through the customers list to sell by price.
            /*for (int i = 0; i < customers.Count; i++)*///Should this be a foreach??
            foreach (Customer customer in customers)
            {
                //I need to bring in how many cups I have of lemonade made. 
                Console.WriteLine("Ohh look lemonade. How much is a cup?");
                if (cupsToSell > 0)
                {
                    int purchased = customer.PurchaseLemonade();
                    cupsSold += purchased;
                    cupsToSell -= purchased;
                    dailyIncome += purchased * price;
                 }
                else if (customers.Count == 0)
                {
                    Console.WriteLine("I guess thats all the customers we get for the day.");
                }
                else
                {
                    Console.WriteLine("Sorry, we are sold out!");
                    //Console.WriteLine($"Cups sold today: {cupsSold}");
                    //Console.WriteLine($"Todays take: ${dailyIncome}");
                    Console.WriteLine("\nNext time we need to make more!!\n");
                
                }
            }

            Console.WriteLine($"Cups sold today: {cupsSold}");
            Console.WriteLine($"Todays take: ${dailyIncome}");
            return dailyIncome;
            
        }
    }
}
