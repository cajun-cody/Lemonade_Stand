using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather : Game
    {
        //Member Variables- We define these types to be able to use in the constructor and the methods
        public List<string> condition; //Sunny, Rainy, Windy
        public int temperature; //Temp range of 90, 80, 70
        private Dictionary<int,string> weatherConditions; //Combination list of int and string to hold condition and temp
        //public Random random;
        public string predictedCondition;

        //Constructor
        public Weather()
        {
            temperature = 0;   
            condition = new List<string> {"Sunny", "Rainy", "Windy", "Sunny"}; //2 Sunny options to make odds of sunny better. 
            predictedCondition = "";
            //this.random = random;
            weatherConditions = new Dictionary<int, string> (); //Empty string we will add temp and condition to in methods.
            //PredictWeather(); //Method to get temp and condition.
        }

        //Member Methods
        //SOLID
        public void PredictCondition()
        {
            int index = random.Next(condition.Count);
            predictedCondition = condition[index];

        }
        //SOLID
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
       
            //Array to hold days of the week. 
                string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thuesday", "Friday", "Saturday", "Sunday" };
                Console.WriteLine($"Here is this week's forecast!!");
                //Loop over the amount of days in the week.
                for (int i = 0; i < 7; i++)
                {
                    PredictWeather (); //Get the temp and condition
                    //Use a while loop to check if predictedCondition has all unique keys then run predict weather again. 
                    while (weatherConditions.ContainsKey(temperature))
                {
                    PredictWeather();
                }
                    weatherConditions.Add(temperature, predictedCondition); //Add the temp and condition to dictionary. 
                    Console.WriteLine($"{daysOfWeek[i]}'s weather should be {temperature} and {predictedCondition}");
 
                }


        }
        public void ActualWeatherForTheDay()
        {
            //Print what the actual weather for the day is each day. 
            //Check to see if day of the week it is. 
            PredictWeather(); //Get a rerandomized temp and condition.
            Console.WriteLine($"\nToday's weather is {temperature} and {predictedCondition} ");

        }

    }
}
