using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public static class ClassClass1
    {
        public static void Method1(int x)
        {
            int v = x / 2;
            Console.WriteLine(v);
            Console.ReadLine();
        }
        public static int Method2(int x, out int divi)
        {
            divi = 0;            
            for (int i = 1; i < 4; i++)
            {
                int v = x / i;
                Console.WriteLine(v + " = " + x + " / " + i);
                Console.ReadLine();
                divi = i;
                Console.WriteLine("divi = " + divi);
                Console.ReadLine();
            }
            return divi;            
        }
        public static int Method2(string x, out int divi)
        {
            divi = 0;
            int xI = Convert.ToInt32(x)*2;
            for (int i = 1; i < 4; i++)
            {
                int v = xI / i;
                Console.WriteLine(v + " = " + x + " / " + i*.5);
                Console.ReadLine();
                divi = i;
                Console.WriteLine("divi = " + divi);
                Console.ReadLine();
            }
            return divi;
        }
    }
}
