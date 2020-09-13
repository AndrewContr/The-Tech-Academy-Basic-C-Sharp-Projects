using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    public class Employee : IQuittable
    {
       public void Quit(int number)
        {
            Console.WriteLine(number + 1);
        }
    }
}
