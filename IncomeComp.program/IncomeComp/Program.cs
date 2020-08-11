using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            float hourRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float perWeek1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            float hourRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float perWeek2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1");
            float annual1 = (hourRate1 * perWeek1 * 52);
            Console.WriteLine(annual1 + " dollars per year");

            Console.WriteLine("Annual Salary of Person 2");
            float annual2 = (hourRate2 * perWeek2 * 52);
            Console.WriteLine(annual2 + " dollars per year");

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moreMoney = annual1 > annual2;
            Console.WriteLine(moreMoney);
            Console.ReadLine();


        }
    }
}
