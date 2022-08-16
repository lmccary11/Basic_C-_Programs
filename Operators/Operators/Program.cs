using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee();
            joe.Id = 5;
            Employee Tim = new Employee();
            Tim.Id = 5;
            bool ha = joe == Tim;
            Console.WriteLine(Convert.ToString(ha));
            Console.ReadLine();


        }
    }
}
