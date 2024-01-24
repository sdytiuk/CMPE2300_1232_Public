/* TODO:
 * * commenting standards
 * comment block on each file
 * * type library
 * * static demo
 * Steven Dytiuk
 * 2024-01-24
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static_class;

namespace static_demo
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Sydney's Notes: " + Demo.TransitSystem);
            Demo colesBus = new Demo("St. Albert Centre", "StAT01");
            Thread.Sleep(1000);
            Console.WriteLine("Cole's Notes: " + Demo.TransitSystem);
            Demo griffinBus = new Demo("Mill Woods TC", "123");
            Demo akilBus = new Demo("Honolulu", "Ford F150");
            Demo sydneyBus = new Demo("Honolulu", "Ford F150");

            //we are displaying multiple randoms to test it
            //
            Console.WriteLine(Demo.random.Next());
            Console.WriteLine(Demo.random.Next());
            Console.WriteLine(Demo.random.Next());
            Console.WriteLine(Demo.random.Next());

            //showing the difference between static method and instance method
            Console.WriteLine(Demo.AreTheDemosTheSame(akilBus,sydneyBus));
            Console.WriteLine(Demo.AreTheDemosTheSame(griffinBus, sydneyBus));
            Console.WriteLine(colesBus.AmITheSameAs( sydneyBus));

            Console.ReadLine();
        }
    }
}
