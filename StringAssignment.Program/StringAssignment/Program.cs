using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string con = "Welcome to ";
            string cate = "Jurassic Park: ";
            string nate = "Dubai, UAE.";

            cate = cate.ToUpper();
            
            Console.WriteLine(con + cate + nate);

            StringBuilder shinning = new StringBuilder();

            shinning.Append("All work and no play\n");
            shinning.Append("makes Jack a dull boy.\n");
            shinning.Append("However, no TV and no beer\n");
            shinning.Append("makes Homer go crazy.");

            Console.WriteLine(shinning);

            Console.ReadLine();
        }
    }
}
