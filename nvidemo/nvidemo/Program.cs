using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nvidemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerLogger x = new DerLogger();
            x.Log("Cole is confused now.");

            ColeLager y = new ColeLager();
            y.Log("Cole is refreshed now.");

            Console.ReadLine();
        }

        /* Abstract Class
         * can't have an instance
         * Purpose is to derive from it
         * */
        abstract class Logger
        {
            public void Log(string message) 
            { 
                Console.WriteLine(DateTime.Now.ToShortTimeString());
                if (this is ColeLager)
                {
                    Console.WriteLine("Wow, Cole comes up with strange ideas!");
                }
                VLog(message);
                Console.WriteLine("Done");
            }

            protected abstract void VLog(string message);


        }

        class DerLogger : Logger
        {
            protected override void VLog(string message)
            {
                Console.WriteLine($"DerLogger : {message}");
            }
        }

        class ColeLager : Logger
        {
            protected override void VLog(string message)
            {
                Console.WriteLine($"ColeLager : {message}");
            }
        }
    }
}
