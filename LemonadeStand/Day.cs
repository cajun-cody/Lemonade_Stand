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

        //Constructor
        public Day()
        {
            weather = new Weather();
            //customer = new List<Customer>();
            
        }
        
        //Member Variables
        public void DailyPredictedWeather()
        {
            weather.PredictWeather();
        }

        //Calculate Customers
            //Conditionals for temp to give the amount of customers that day.
            //Variable to hold customers
            //Loop through variable to create new customers. 


        //Calculate sales
            //variable to hold total cups sold
            //variable to hold income from sales
            //Loop through the customers list to sell 

    }
}
