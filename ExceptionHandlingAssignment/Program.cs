using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>() { 40, 69, 101, 4, 12 };
                Console.WriteLine("Please input a number by which to divide each number in the list.");
                int divider = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                foreach (int list in intList)
                {
                    Console.WriteLine(list / divider);
                }
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (DivideByZeroException ex2)
            {
                Console.WriteLine(ex2.Message);
            }    
            catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution.");
                Console.ReadLine();
            }
            
            
                Console.ReadLine();
        }
    }
}
