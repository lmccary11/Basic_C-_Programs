using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Class1
    {
        private string paper;    //Initial values                          
        public bool recycled;                   
        public bool chemicallyPulped;

        public Class1() : this("Hardwood", false, true)       
        {
            Console.WriteLine((paper) + ((paper == "Hardwood" ^ paper == "Softwood") ? " Trees!" : " recycled sources."));
            Console.Read();
            return;
        }
        public Class1(string paper, bool recycled, bool chemicallyPulped) 
        {
            this.paper = paper;
            this.recycled = recycled;
            this.chemicallyPulped = !chemicallyPulped;
            Console.WriteLine((paper) + ((paper == "Hardwood" ^ paper == "Softwood") ? " Trees!" : " recycled sources."));
            Console.Read();
            return;
        }
        public Class1(string paper) : this(paper, false, true)       
        {
            //Determining that good operations are when wood is either chemically pulped or recycled.
            //Testing that the good state is true in the present and if so which process is occurring.
            //Description of how the material is prepared.
            Console.WriteLine(paper + ((paper == "Hardwood" ^ paper == "Softwood") ? " Trees!" : " recycled sources."));
            Console.Read();
            return;

        }
        public Class1(bool recycled) : this("Newspaper", recycled, true)      
        {
            Console.WriteLine((paper) + ((paper == "Hardwood" ^ paper == "Softwood") ? " Trees!" : " recycled sources."));
            Console.Read();

            return;
        }
    }
}