using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            byte howOld = (byte)Convert.ToInt32(Console.ReadLine());
            bool oldEnough = howOld > 15;
            Console.WriteLine(oldEnough);

            Console.WriteLine("Have you ever had a DUI? Please answer 'yes' or 'no'.");
            string noDrink = Console.ReadLine();
            bool anyDUI = noDrink == "yes";
            Console.WriteLine(anyDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            byte speedT = (byte)Convert.ToInt32(Console.ReadLine());
            bool sTick = speedT < 3;
            Console.WriteLine(sTick);

            Console.WriteLine("Qualified?");
            Console.WriteLine(oldEnough && sTick ^ anyDUI); 
            
            Console.ReadLine();
            
        }
    }
}
