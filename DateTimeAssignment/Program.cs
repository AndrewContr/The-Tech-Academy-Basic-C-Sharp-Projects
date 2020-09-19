using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number.");
            int timeNum = Convert.ToInt32(Console.ReadLine());
            DateTime future = DateTime.Now + TimeSpan.FromHours(timeNum); 
            Console.WriteLine(future);
            Console.ReadLine();
        }
    }
}
