using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Groucho", "Harpo", "Zeppo", "Shemp", "Bono" };
            Console.WriteLine("Please select an index of the first array.");
            byte index1 = Convert.ToByte(Console.ReadLine());
           
            if (index1 > 4)
            {
                Console.WriteLine("That index does not exist in this array.");
            }
            else
            {
                Console.WriteLine(stringArray[index1]);
                
                int[] numArray = { 2, 4, 6, 8, 70 };
                Console.WriteLine("Please select an index of the second array.");
                byte index2 = Convert.ToByte(Console.ReadLine());
                if (index2 > 4)
                {
                    Console.WriteLine("That index does not exist in this array.");
                }
                else
                {
                    Console.WriteLine(numArray[index2]);

                    List<string> stringList = new List<string>();
                    stringList.Add("Moe");
                    stringList.Add("Larry");
                    stringList.Add("Curly");
                    stringList.Add("Butters");
                    stringList.Add("Charlemagne");
                    Console.WriteLine("Please select an index of the list.");
                    byte index3 = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine(stringList[index3]);
                    }
            }
            Console.ReadLine();
        }
    }
}
