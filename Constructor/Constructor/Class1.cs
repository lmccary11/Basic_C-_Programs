using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Class1
    {
        public Class1() : this("Softwood")
        {

        }
        public  Class1(string paper) : this(paper, 5)
        {

        }
        public Class1(string paper, int numMills)
        {
            bool good = paper == "Softwood";
            string material = "recycled " + paper;
            numMills = 13;      
        }
    }
}