using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}

