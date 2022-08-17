using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_and_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
            Console.WriteLine("Pick a number");
            int x = Convert.ToInt32(Console.ReadLine());
            TimeSpan y = new TimeSpan(x, 0, 0);
            DateTime plusY = new DateTime();
            plusY = DateTime.Now + y;

            Console.WriteLine("It will be " + plusY + " in " + x + " hours.");
            Console.ReadLine();
        }
    }
}
