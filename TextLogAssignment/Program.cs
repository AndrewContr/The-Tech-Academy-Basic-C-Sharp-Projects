using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextLogAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int numNum = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\andre\log.txt", true))
            {
                file.WriteLine(numNum);
                Console.WriteLine(numNum);
            }
            Console.ReadLine();
        }
    }
}
