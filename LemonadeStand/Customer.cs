using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        //Member Variables
        public string name;


        //Constructor
        public Customer()
        {
            name = "Customer";
        }

        //Member Methods

        //Needs to be able to purchase a cup. 
        public int PurchaseLemonade(Random random, int purchaseProbability)
        {
            int toBuy = random.Next(purchaseProbability);
        }
            //Need to have most customers buy but some not. 
            //Conditional if customer purchases then add value to sold cups. 
    }
}
