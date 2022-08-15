using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntMethod
{
    class TwoIntClass
    {
        public static int TwoIntMethod1(string v, string w = "4")
        {
            int x = Convert.ToInt32(v);
            int u = Convert.ToInt32(w);
            int y = x * x * x / u;
            Console.WriteLine(x + " * " + x + " * " + x + " / " + w);
            Console.ReadLine();
            return y;
        }
    }
}
