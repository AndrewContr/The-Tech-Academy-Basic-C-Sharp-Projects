using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegerParameterClassAssignment
{
    public class Calculator
    {
       public int addTwo(int number1, int number2)
        {
            return number1 + number2;
        }
        public int addTwo(int number1)
        {
            return number1 + 5;
        }
    }
}
