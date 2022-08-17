using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Class1
    {
        const string okayPaper = "Softwood";    //Declaring the constant okayPaper with value of softwood
        const int NewAge = 25;                  //Declaring the constant okayPaper with value of softwood
        public bool recycled;                   //Initial values for boolean attributes
        public bool chemicallyPulped;

        public Class1() : this(okayPaper, false, true, 5)       //Constructor chained to other constructor, using constant to choose last parameter.
        {

        }
        public Class1(string paper) : this(paper, true, false, 3) //Constructor initializing 3 things on the Class1 object.
        {
        }
        public Class1(string paper, bool recycled, bool chemicallyPulped, int numMills) //Object with parameters.
        {            
            bool good = paper == "Softwood" && (chemicallyPulped == true ^ recycled == true);  
            //Determining that good operations are when Softwood is either chemically pulped or recycled, not neither, not both, no hardwood.         
            var process = good ? ((chemicallyPulped == !recycled) ? "chemically pulped chips from " : "mechanically pulped recycled bales of ") : "Not a viable process for ";
            //Testing that the good state is true in the present and if so which process is occurring.
            var material = process + paper;                 //Description of how the material is prepared.
            var marketLongevity = Class1.NewAge * numMills; //Calculation of years and depth of mills operational.
            return;
        }
    }
}