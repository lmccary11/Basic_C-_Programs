using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class OneMethod
    {
        public static int method1(int x)
        {
            return x * x * x;
        }
        public static int method2(decimal x)
        {
            int xInt = Convert.ToInt32(x);
            int y = xInt + xInt * xInt;
            Console.WriteLine(y);
            Console.ReadLine();
            return y;
        }
        public static int method3(string x)
        {
            int xInt = Convert.ToInt32(x);
            int y = xInt + xInt + xInt;
            Console.WriteLine(y);
            Console.ReadLine();
            return y;
        }
    }
}
