using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        //Member Variables
        public string name;
        //int toBuy;

        //Constructor
        public Customer()
        {
            name = "Customer";
        }

        //Member Methods

        //Needs to be able to purchase a cup depending on price.  
        public int PurchaseLemonade()
        {
            
            Console.WriteLine("Lemonade Sold!!");
            return 1;
        }
          
    }
}
