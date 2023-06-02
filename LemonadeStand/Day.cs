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


    }
}
