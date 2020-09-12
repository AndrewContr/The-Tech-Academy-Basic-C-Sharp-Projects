using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamplerAssignment
{
    static class Labor
    {
        public static int doWork(out int number1)
        {
            number1 = 9;
            return number1 * 10;
        }

        public static int doWork(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
