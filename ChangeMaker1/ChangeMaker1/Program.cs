using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);
            Console.ReadKey();
        }

        static void ChangeMaker(double amount)
        {
            //declare all variables
            double quarters = 0;
            double dimes = 0;
            double nickels = 0;
            double pennies = 0;
            double total = amount;

            //Running while loop for quarter
            while (total > 0.25)
            {
                total -= 0.25;
                quarters++;
                    
            }
            //running while loop for dime
            while (total > 0.10)
            {
                total -= 0.10;
                dimes++;
            }

            //running while loop for nickel
            while (total > 0.05)
            {                total -= 0.05;
                nickels++;

            }
            //running while loop for penny
            while (total > 0.01)
            {
                total -= 0.01;
                pennies++;
                    
            }
            //Printing out all the coins and the total amount
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickles: " + nickels);
            Console.WriteLine("Pennies: " + pennies);
            Console.WriteLine("Total Amount: $" + amount);

        }
    }
}
