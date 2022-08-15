using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person, IQuittable
    {        
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine(FirstName + " " + LastName + " has resigned.");
            Console.ReadLine();
        }
    }
}

