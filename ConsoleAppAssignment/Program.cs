using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Assignment 1
            //string[] textArrays1 = { "Sealion", "Barbarossa", "Torch", "Overlord", "Olympic" };
            //Console.WriteLine("Please input a line of text.");
            //string userText = Console.ReadLine();

            //for (int i = 0; i < textArrays1.Length; i++)
            //{
            //    Console.WriteLine(textArrays1[i] + userText);    
            //}
            //Console.ReadLine();

            ////Assignment 2
            //for (; ;)
            //{ }

            ////Assignment 3
            //int[] numArray1 = { 1, 2, 3, 4 };

            //for (int j = 0; j < numArray1.Length; j++)
            //{
            //    Console.WriteLine("This loop is now finite.");
            //}

            ////Assignment 3
            //int[] arrayLoop = { 12, 40, 720, 56, 90 };

            //for (int p = 0; p < arrayLoop.Length; p++)
            //{
            //    Console.WriteLine(arrayLoop[p]);
            //}
            //Console.ReadLine();



            //List<string> stringLoop = new List<string>() { "He-Man", "She-Ra", "McCoy", "Skeletor", "Prospero" };

            //for (int q = 0; q <= 5; q++)
            //{
            //    Console.WriteLine(stringLoop[q]);
            //}
            //Console.ReadLine();

            //Assignment 4
            //List<string> loopedList = new List<string>() { "John", "Paul", "Real Paul", "George", "Ringo" };
            //Console.WriteLine("Please input text to search for in the list.");
            //string userLoop = Console.ReadLine();

            //foreach (string name in loopedList)
            //{
            //    if (name == userLoop)
            //    {
            //        Console.WriteLine(loopedList.IndexOf(userLoop));
            //        break;
            //    }
            //    else if (loopedList.IndexOf(userLoop) < 0)
            //    {
            //        Console.WriteLine("The input text does not match any item in the list.");      
            //    }
            //}  
            //Console.ReadLine();

            //Assignment 5
            //List<string> ideStrings = new List<string>() { "Hun", "Mongol", "Goth", "Hun", "Emo" };
            //Console.WriteLine("Please input text to search for in the list.");
            //string checkLoop = Console.ReadLine();


            //if (ideStrings.IndexOf(checkLoop) != ideStrings.LastIndexOf(checkLoop))
            //{
            //    Console.WriteLine(ideStrings.IndexOf(checkLoop));
            //    Console.WriteLine(ideStrings.LastIndexOf(checkLoop));
            //}
            //else if (ideStrings.IndexOf(checkLoop) >= 0 && ideStrings.IndexOf(checkLoop) == ideStrings.LastIndexOf(checkLoop))
            //    {
            //        Console.WriteLine("The input text only appears at one index in the list.");
            //    }
            //    else
            //    {
            //    Console.WriteLine("The input text does not match any item in the list.");
            //}
            //Console.ReadLine();

            //Assignment 6
            List<string> crayDiam = new List<string>() { "Laser", "Blazer", "Michelle", "White", "Blazer" };
            
            foreach (string syd in crayDiam)
            {
                if (crayDiam.IndexOf(syd) != crayDiam.LastIndexOf(syd))
                {
                    Console.WriteLine("The string " + syd + " has already appeared in this list.");
                }
                else
                {
                    Console.WriteLine("The string " + syd + " only appears once in this list.");
                }
            }
            Console.ReadLine();


        }

    }
}
