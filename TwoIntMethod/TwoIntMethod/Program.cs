using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want the operations on?");
            string num = Console.ReadLine();
            Console.WriteLine("What other number do you want in the equation?\n This is optional.");
            string num2 = Console.ReadLine();
            if (num2 == "")
            {
                int calc1 = TwoIntClass.TwoIntMethod1(num);
                Console.WriteLine(calc1);
                Console.ReadLine();
            }
            else
            {
                int calc1 = TwoIntClass.TwoIntMethod1(num, num2);
                Console.WriteLine(calc1);
                Console.ReadLine();
            }
        }
    }
}

