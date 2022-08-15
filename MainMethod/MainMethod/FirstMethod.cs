using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class FirstMethod
    {
        public static int method1(int x)
        {
            int y = x * x * x;
            Console.WriteLine(x + " * " + x + " * " + x);
            Console.ReadLine();
            return y;
        }
        public static int method1(decimal x)
        {
            int xInt = Convert.ToInt32(x);
            int y = xInt + xInt * xInt;
            Console.WriteLine(xInt + " + " + xInt + " * " + xInt);
            Console.ReadLine();            
            return y;
        }
        public static int method1(string x)
        {
            int xInt = Convert.ToInt32(x);
            int y = xInt + xInt + xInt;
            Console.WriteLine(xInt + " + " + xInt + " + " + xInt);
            Console.ReadLine();
            return y;
        }
    }

}
