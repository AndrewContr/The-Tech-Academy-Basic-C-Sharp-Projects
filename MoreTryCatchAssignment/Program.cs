using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreTryCatchAssignment
{
    public class Program
    {
       static void Main(string[] args)
        {
           
                Console.WriteLine("Please enter your age");
                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {
                        Console.WriteLine("Please enter only numbers greater than zero.");
                        Console.ReadLine();
                    }
                    else
                    {
                        TimeSpan lifeTime = DateTime.Now.AddYears(age) - DateTime.Now;
                        DateTime birthYear = DateTime.Now - lifeTime;
                        Console.WriteLine(birthYear.Year);
                        Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred. Please contact your system administrator.");
                    Console.ReadLine();
                    return;
                }
                
              
            }
        }
    }
