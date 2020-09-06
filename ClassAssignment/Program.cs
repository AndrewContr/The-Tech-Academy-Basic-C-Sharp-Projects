using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int testSub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Calculator.addOne(testSub));
            Console.WriteLine(Calculator.squareNum(testSub));
            Console.WriteLine(Calculator.minusOne(testSub));
            Console.ReadLine();
            ;
            
        }
    }
}
