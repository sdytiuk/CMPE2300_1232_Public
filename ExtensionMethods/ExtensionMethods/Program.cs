using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ShaneQuestion
    {
        public static string toFixed3(this double dVal)
        {
            return dVal.ToString("F3");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //double value that you want to display as fixed 2 decimal places
            double x = 3.14159;
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.toFixed2());
            Console.WriteLine(x.toFixed3());
            string cole = "question";
            Console.WriteLine(cole);
            Console.WriteLine(cole.ColesNotes());

            Console.ReadKey();
        }

        
    }
}
