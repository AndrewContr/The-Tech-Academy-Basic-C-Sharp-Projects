using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the weight of the package.");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the width of the package.");

                int packWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the height of the package.");
                int packHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the length of the package.");
                int packLength = Convert.ToInt32(Console.ReadLine());
                if (packWidth + packHeight + packLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    decimal outCome = ((packWidth * packHeight * packLength) * packWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + outCome);
                    Console.WriteLine("Thank you.");

                    Console.ReadLine();
                }
            }
        }
    }
}
