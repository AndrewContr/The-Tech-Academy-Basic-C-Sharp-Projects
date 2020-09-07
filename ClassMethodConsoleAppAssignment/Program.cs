using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer.");
            int wholeNum = Convert.ToInt32(Console.ReadLine());
            Tabulator userInt = new Tabulator();
            Console.WriteLine(userInt.mathOp(wholeNum));
            Console.ReadLine();

            Console.WriteLine("Please enter a decimal number.");
            decimal decNum = Convert.ToDecimal(Console.ReadLine());
            Tabulator userDec = new Tabulator();
            Console.WriteLine(userDec.mathOp(decNum));
            Console.ReadLine();

            Console.WriteLine("Please write a number as a string.");
            short fromString = (short)Convert.ToInt32(Console.ReadLine());
            Tabulator userString = new Tabulator();
            Console.WriteLine(userString.mathOp(fromString));
            Console.ReadLine();
        }
    }
}
