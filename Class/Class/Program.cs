using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want the operations on?");
            int num = Convert.ToInt32(Console.ReadLine());
            ClassClass1.Method1(x: num);

            ClassClass1.Method2(x: num, out int divi);
            Console.WriteLine(divi);            
            string divStr = Convert.ToString(divi);
            ClassClass1.Method2(x: divStr, out int xI);
            Console.WriteLine("xI * divi * v = " + xI + " * " + divi + " = " + xI * divi);
            Console.ReadLine();

        }
    }
}
