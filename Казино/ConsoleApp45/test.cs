using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp45
{
    class test
    {
        static public int val;

        public void calc()
        {
            val = val + 2;
        }

        public static void kek(int val11)
        {
            val = 1;
            Console.WriteLine(val11);
        }
    }
}
