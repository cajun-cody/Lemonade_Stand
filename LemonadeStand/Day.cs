using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        //Member Variables (Has A)
        public Weather weather;
        public List<Customer> customer;
        public Random random;
        public int purchaseProbability;

        //Constructor
        public Day()
        {
            weather = new Weather();
            customer = new List<Customer>();
            purchaseProbability = 0;

        }
        
        //Member Variables
        public void DailyPredictedWeather()
        {
            weather.ActualWeatherForTheDay();
        }

        public void RunDay()
        {
            DailyPredictedWeather();
            Random random = new Random();
            
        }

        //Calculate Customers
        public void EstimateCustomers()
        {
            //Customer estimated on daily condition
            int estimatedCustomers = 0;
            
            if (weather.predictedCondition == "Rainy")
            {
                estimatedCustomers = 10;
                purchaseProbability = 5;
            }
            else if (weather.predictedCondition == "Windy")
            {
                estimatedCustomers = 20;
                purchaseProbability = 10;
            }
            else
            {
                estimatedCustomers = 30;
                purchaseProbability = 15;
            }
            
            //Loop to Create customers off of estimation. 
            for (int i = 0; i < estimatedCustomers; i++)
            {
                customer.Add(new Customer());
            }

        }

        //Calculate sales depending on price per cup. Need to have parameters for cups and price. 
        //If no cups left then sold out. If price is too high, customer doesn't buy. 
       public void DailySales(int cupsLeft, double price)
        {
            int cupsSold = 0;
            double dailyIncome = 0;
            foreach (Customer person in customer)
            {
                Console.WriteLine("Ohh look lemonade. How much is a cup?");
                if (cupsLeft > 0)
                {
                    //Conditional on if price is too high or too low. 
                    if (price > 0)
                    {
                        int purchased = person.
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, we are sold out!");
                }
            }

        }
            //variable to hold total cups sold
            //variable to hold income from sales
            //Loop through the customers list to sell by price.


    }
}
