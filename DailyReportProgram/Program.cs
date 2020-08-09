using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("The course you are currently on is: " + yourCourse);

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            ushort pNum = Convert.ToUInt16(pageNumber);
            Console.WriteLine("Your current page number is " + pNum);

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            string needHelp = Console.ReadLine();
            bool neHel = Convert.ToBoolean(needHelp);
            Console.WriteLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string feedBack = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string specIfics = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            byte hoStud = Convert.ToByte(hoursStudy);
            Console.WriteLine("Today, you studied for " + hoStud + " hours.");

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
