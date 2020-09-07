using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodConsoleAppAssignment
{
    class Tabulator
    {
        public int mathOp(int number)
        {
            return number + 1;
        }
    
        public int mathOp(decimal number)
        {
            return (int)number * 4; 
        }

        public int mathOp(short number)
        {
            return number -1;       
        } 
    }
}
