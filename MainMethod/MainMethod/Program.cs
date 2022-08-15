using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want the operations on?");
            string num = Console.ReadLine();
            int calc1 = FirstMethod.method1(Convert.ToInt32(num));
            Console.WriteLine(calc1);
            Console.ReadLine();
            int calc2 = FirstMethod.method1(Convert.ToDecimal(num));
            Console.WriteLine(calc2);
            Console.ReadLine();
            int calc3 = FirstMethod.method1(num);
            Console.WriteLine(calc3);
            Console.ReadLine();
        }
    }
}
