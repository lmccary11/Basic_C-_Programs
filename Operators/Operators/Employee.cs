using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Employee personObj = obj as Employee;
            if (personObj == null)
                return false;
            else
                return Equals(personObj);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }


        public static bool operator ==(Employee person1, Employee person2)
        {
            return (person1.Id == person2.Id);
        }

        public static bool operator !=(Employee person1, Employee person2)
        {
            return (person1.Id != person2.Id);
        }




    }
}
