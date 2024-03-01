using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        //a custom extension method is always decorated with this
        public static string toFixed2(this double dVal)
        {
            return dVal.ToString("F2");
        }

        public static string ColesNotes(this string sVal)
        {
            return "Cole's " + sVal + " is always number 1!";
        }
    }
}
