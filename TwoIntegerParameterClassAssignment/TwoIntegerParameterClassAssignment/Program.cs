using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegerParameterClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
        Calculator kalc = new Calculator();
        Console.WriteLine("Please enter a number.");
        int numA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter a second number if you wish.");
        int numB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(kalc.addTwo(numA, numB));
        Console.ReadLine();
            
            
            
        }
    }
}
