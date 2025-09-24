using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Calc
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }

        public int Subtraction(int x, int y)
        {
            return x - y;
        }
        public int NoIntDivision(int x, int y) {
            return x % y;
        }
        public int Division(int x, int y) { 
            return x / y;
        }
    }
}
