using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        const string okayPaper = "Softwood";
        

        static void Main(string[] args)
        {
            Class1 classOne = new Class1(okayPaper, true, false);
            var one = Console.ReadLine().Length;
            Class1 classTwo = new Class1();
            var two = Console.ReadLine().Length;
            Class1 classThree = new Class1("Newspaper");
            var three = Console.ReadLine().Length;
            Class1 classFour = new Class1(true);
            var four = Console.ReadLine().Length;

            

        }


    }
        
            
       
       
}
        
                          
            
 