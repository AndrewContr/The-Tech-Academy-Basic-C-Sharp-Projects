using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int guess = Convert.ToInt32(Console.ReadLine());
            bool correct = guess == 49;

            while (!correct)
            {
                switch (guess)
                {
                    case 12:
                        Console.WriteLine("12 is mistaken. Try again.");
                        Console.WriteLine("Guess a number?");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 48:
                        Console.WriteLine("You guessed 48. Close, but try again.");
                        Console.WriteLine("Guess a number?");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 50:
                        Console.WriteLine("You guessed 50. Close, but try again.");
                        Console.WriteLine("Guess a number?");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 49:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        correct = true;
                        break;
                    default:
                        Console.WriteLine("Nope.");
                        Console.WriteLine("Guess a number?");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

        }
    }
}
   
        
    

