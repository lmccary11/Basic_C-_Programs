using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want the operations on?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What other number do you want in the equation?\n This is optional.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            MethodClass1.Method1(x: num, w: num2);
            
            
        }
    }
}
