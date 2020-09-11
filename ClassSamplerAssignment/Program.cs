using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamplerAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor actee = new Actor();
            Console.WriteLine("Please enter a number.");
            int useNum = Convert.ToInt32(Console.ReadLine());
            actee.inact(useNum);
            Console.ReadLine();
        }
    }
}
