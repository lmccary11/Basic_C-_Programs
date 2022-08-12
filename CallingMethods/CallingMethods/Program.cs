using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want the operations on?");
            int num = Convert.ToInt32(Console.ReadLine());
            int calc1 = MathOperations.method1(num);
            Console.WriteLine(calc1);
            Console.ReadLine();
            int calc2 = MathOperations.method2(num);
            Console.WriteLine(calc2);
            Console.ReadLine();
            int calc3 = MathOperations.method3(num);
            Console.WriteLine(calc3);
            Console.ReadLine();
        }
    }
}
