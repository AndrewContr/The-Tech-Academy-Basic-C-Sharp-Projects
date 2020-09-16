using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EnumChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");
            try
            {
                String dayString = Console.ReadLine();
                DaysOfTheWeek dayValue = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayString, true);
                if (Enum.IsDefined(typeof(DaysOfTheWeek), dayValue) | dayValue.ToString().Contains(","))
                    Console.WriteLine("Converted '{0}' to {1}.", dayString, dayValue.ToString());
                else
                    Console.WriteLine("Please enter an actual day of the week.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
            
            
            public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }     
}
        

