/* comment block
 * Steven Dytiuk
 * This demos static and instance features of a class 
 * in the context of busses that go places
 * 2024-01-24 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
//the above talks about REAL static classes
//THIS is not a real static class
namespace static_class
{
    public class Demo
    {
        #region privatefields
        private string _destination; //where the train is going
        private string _carNo; //what is the car number
        static string Something = "My static string"; //just to demo
        public static Random random = null; //demoing that random should be static
        #endregion
        #region constructors
        /// <summary>
        /// Creates a new instance of demo
        /// passing in the destination and carno
        /// </summary>
        /// <param name="dest">where the bus is going</param>
        /// <param name="carNo">what is the car number</param>
        public Demo(string dest, string carNo)
        {
            _destination = dest;
            _carNo = carNo;
            
        }
        /// <summary>
        /// Static Constructor
        /// PARAMETERLESS
        /// Invoked when first needed
        /// usually when an instance is created
        /// But, could be when a static member is used
        /// </summary>
        static Demo()
        {
            Console.Write("Invoked Static Constructor");
            TransitSystem = "ETS";
            random = new Random();
        }
        #endregion

        #region properties
        public string destination
        {
            get { return _destination; }
            private set { _destination = value; }
        }
        public string carNo
        { get { return _carNo; } }

        //automatic property:
        public static string TransitSystem { get; private set; }
        #endregion
        #region methods
        static public bool AreTheDemosTheSame(Demo demo1, Demo demo2)
        {
            return demo1.destination == demo2.destination &&
                demo1.carNo == demo2.carNo;
        }

        public bool AmITheSameAs(Demo another)
        {
            return AreTheDemosTheSame(this, another);
            
        }
        #endregion
    }
}
