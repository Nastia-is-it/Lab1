using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Test
    {
        public int Test1(int x, int y)
        {
            return 0;
        }
        public void Test2(int a, int b) {
            Console.WriteLine("a + b = " + Test3(a, b));
        }

        private int Test3(int x, int y) {
            return x + y;
        }
    }
}
