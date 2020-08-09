using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            string input1 = Console.ReadLine();
            int inP1 = Convert.ToInt32(input1);
            int product = inP1 * 50;
            Console.WriteLine(input1 + " times 50 = " + product);
            
            Console.WriteLine("Please input a number.");
            string input2 = Console.ReadLine();
            int inP2 = Convert.ToInt32(input2);
            int total = inP2 + 25;
            Console.WriteLine(input2 + " plus 25 = " + total);

            Console.WriteLine("Please input a number.");
            string input3 = Console.ReadLine();
            double inP3 = Convert.ToDouble(input3);
            double quotient = inP3 / 12.5;
            Console.WriteLine(input3 + " divided by 12.5 = " + quotient);

            Console.WriteLine("Please input a number.");
            string input4 = Console.ReadLine();
            int inP4 = Convert.ToInt32(input4);
            bool trueOrFalse = inP4 > 50;
            Console.WriteLine(input4 + " is greater than 50: " + trueOrFalse);

            Console.WriteLine("Please input a number.");
            string input5 = Console.ReadLine();
            int inP5 = Convert.ToInt32(input2);
            int remainder = inP5 % 7;
            Console.WriteLine("The remainder of " + input5 + " divided by 7 = " + remainder);
            Console.ReadLine();
        }
    }
}
