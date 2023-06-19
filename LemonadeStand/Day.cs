using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            //This is a new list of customers. Not filled up yet. 
            customer = new List<Customer>();
            purchaseProbability = 0;
            random = new Random();
        }
        
        //Member Variables
        public void DailyPredictedWeather()
        {
            weather.ActualWeatherForTheDay();
        }

        public void RunStand()
        {
            //Actual Weather.
            DailyPredictedWeather();
            //Estimate Customers.
            EstimateCustomers();
            //Calculate sales depending on price. //Sales will depend on cups and price.
            
            
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
            //Else carries sunny condition.
            else
            {
                estimatedCustomers = 30;
                purchaseProbability = 15;
            }
            
            //Loop to Create customers off of estimation depending on purchaseProbability. 
            for (int i = 0; i < estimatedCustomers; i++)
            {
                
                if (purchaseProbability == 5)
                {
                    int bigSpenders = new Random().Next(5, 10);
                    customer.Add(new Customer(bigSpenders));
                }
                else if (purchaseProbability == 10)
                {
                    int bigSpenders = new Random().Next(10, 20);
                    customer.Add(new Customer(bigSpenders));
                }
                else if (purchaseProbability == 15)
                {
                    int bigSpenders = new Random().Next(20, 30);
                    customer.Add(new Customer(bigSpenders));
                }

            }

        }

        //Calculate sales depending on if inventory of cups is sold out. Display sales at the end. 
       public void DailySales(int cupsToSell,  double price)
        {
            //variable to hold total cups sold
            //variable to hold income from sales
            int cupsSold = 0;
            double dailyIncome = 0;
           
            //Loop through the customers list to sell by price.
            foreach (Customer person in customer)
            {
                //I need to bring in how many cups I have of lemonade made. 
                Console.WriteLine("Ohh look lemonade. How much is a cup?");
                if (cupsToSell > 0)
                {
                    int purchased = person.PurchaseLemonade();
                    cupsSold++;
                    cupsToSell--;
                    dailyIncome += cupsSold * price;
                 }
                else
                {
                    Console.WriteLine("Sorry, we are sold out!");
                }
            }
            Console.WriteLine($"Cups sold today: {cupsSold}");
            Console.WriteLine($"Todays take: {dailyIncome}");
        }
            
            


    }
}
