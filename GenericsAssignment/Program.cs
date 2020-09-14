using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> doozy = new Employee<string>();
            doozy.Things = new List<string>() { "Chubby", "Babs", "Kurt", "Rockefeller", "Mandible" };

            Employee<int> crumbsly = new Employee<int>();
            crumbsly.Things = new List<int>() { 48, 9, 69, 70, 234 };

            foreach (int thing in crumbsly.Things)
            {
                Console.WriteLine(thing);
            }
            
            foreach (string thang in doozy.Things)
            {
                Console.WriteLine(thang);
            }
            Console.ReadLine();
        }
    }
}
