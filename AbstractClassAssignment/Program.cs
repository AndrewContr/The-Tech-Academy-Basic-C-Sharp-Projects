using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker = new Employee();
            worker.firstName = "Sample";
            worker.lastName = "Student";
            worker.SayName();
            Console.ReadLine();
        }
    }
}
