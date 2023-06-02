using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        //Member Variables
        private Player player;
        private List<Day> days;
        private int currentDay;
        private Weather weather;
        
        public List<Day> Days { get { return days; } }
        //Constructor
        public Game()
        {
            days = new List<Day>();
            currentDay = 0;
            weather = new Weather();

        }

        //Member Methods

        //Create Current Day
        public void CreateCurrentDay(int numDay)
        {
            for (int i = 0; i < numDay; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
        }

        public void RunGame()
        {
            UserInterface.DisplayWelcome(); //Working
            weather.WeeklyForcast();
            
            

        }

    }
}
