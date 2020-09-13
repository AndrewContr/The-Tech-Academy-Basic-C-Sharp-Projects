using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
     public class Program
    {
        static void Main(string[] args)
        {
            IQuittable quitter = new Employee();
            quitter.Quit(5);
            Console.ReadLine();
        }
    }
}
