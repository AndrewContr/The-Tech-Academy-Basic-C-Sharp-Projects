using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker = new Employee();
            worker.FirstName = "Sample";
            worker.LastName = "Student";
            worker.SayName();
            Console.ReadLine();
        }
    }
}
