using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee(); emp1.FirstName = "John"; emp1.LastName = "Smith"; emp1.Id = 3;
            Employee emp2 = new Employee(); emp2.FirstName = "Joe"; emp2.LastName = "Smitters"; emp2.Id = 7;
            Employee emp3 = new Employee(); emp3.FirstName = "Will"; emp3.LastName = "King"; emp3.Id = 3;
            Employee emp4 = new Employee(); emp4.FirstName = "Harold"; emp4.LastName = "Tiffin"; emp4.Id = 8;
            Employee emp5 = new Employee(); emp5.FirstName = "Joe"; emp5.LastName = "Jordan"; emp5.Id = 8;
            Employee emp6 = new Employee(); emp6.FirstName = "Joe"; emp6.LastName = "Williams"; emp6.Id = 6;
            Employee emp7 = new Employee(); emp7.FirstName = "Joe"; emp7.LastName = "Naples"; emp7.Id = 5;
            Employee emp8 = new Employee(); emp8.FirstName = "John"; emp8.LastName = "Julian"; emp8.Id = 5;
            Employee emp9 = new Employee(); emp9.FirstName = "Mark"; emp9.LastName = "Fink"; emp9.Id = 2;
            Employee emp10 = new Employee(); emp10.FirstName = "Bryan"; emp10.LastName = "Reeves"; emp10.Id = 3;
            List<Employee> emps = new List<Employee>();
            emps.Add(emp1); emps.Add(emp2); emps.Add(emp3); emps.Add(emp4); emps.Add(emp5); emps.Add(emp6);
            emps.Add(emp7); emps.Add(emp8); emps.Add(emp9); emps.Add(emp10);
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in emps)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                    Console.ReadLine();
                    joes.Add(employee);
                }
                else { continue; }
            }
            List<Employee> newList = emps.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine(newList[0].FirstName+" "+newList[0].LastName+"\n"+ newList[1].FirstName + " " + newList[1].LastName + "\n" + newList[2].FirstName + " " + newList[2].LastName + "\n" + newList[3].FirstName + " " + newList[3].LastName);
            Console.ReadLine();
            List<Employee> newList2 = emps.Where(x => x.Id > 5).ToList();
            Console.WriteLine(newList2[0].FirstName + " " + newList2[0].LastName + "\n" + newList2[1].FirstName + " " + newList2[1].LastName + "\n" + newList2[2].FirstName + " " + newList2[2].LastName + "\n" + newList2[3].FirstName + " " + newList2[3].LastName);
            Console.ReadLine();

        }
    }
}
