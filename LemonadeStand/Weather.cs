using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather 
    {
        //Member Variables- We define these types to be able to use in the constructor and the methods
        public List<string> condition; //Sunny, Rainy, Windy
        public int temperature; //Temp range of 90, 80, 70
        private Dictionary<int,string> weatherConditions; //Combination list of int and string to hold condition and temp
       /* public string predictedForcast; *///used to call a method to predict the weatherConditions at random. 
        public Random random;
        public string predictedCondition;

        //Constructor
        public Weather()
        {
            temperature = 0;   
            condition = new List<string> {"Sunny", "Rainy", "Windy", "Sunny"};
            predictedCondition = "";
            random = new Random();
            weatherConditions = new Dictionary<int, string> ();
            PredictWeather();
        }

        //Member Methods
        public void PredictCondition()
        {
            int index = random.Next(condition.Count);
            predictedCondition = condition[index];

        }
        public void PredictTemp()
        {
            if (predictedCondition == "Sunny")
            {
                temperature = random.Next(85,95);
            }
            else if (predictedCondition == "Rainy")
            {
                temperature = random.Next(75,85);
            }
            else if (predictedCondition == "Windy")
            {
                temperature = random.Next(65,75);
            }
        }
        public void PredictWeather()
        {
            PredictCondition();
            PredictTemp();
        }
        public void WeeklyForcast()
        {
            string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thuesday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine($"This weeks forcast is!!");
            for (int i = 0; i < 7; i++)
            {
                PredictWeather ();
                weatherConditions.Add(temperature, predictedCondition);
                Console.WriteLine($"{daysOfWeek[i]}'s weather should be {temperature} and {predictedCondition}");
            }
        }
        public void ActualWeather()
        {
            //Print what the actual weather for the day is each day. 
            //Check to see if day of the week is 0-
        }

    }
}
