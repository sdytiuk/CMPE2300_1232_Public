using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People Adam = new People();
            People Sydney = new People("Sydney","Australia",1);
            People Michael = new People("Sleepy", "Jeffrey", 999888777);

            Console.WriteLine(Adam.ShowYourself());
            Console.WriteLine(Sydney.ShowYourself());
            Console.WriteLine(Michael.ShowYourself());
            Michael.first = "salamander";
            Console.WriteLine(Michael.first);
            Console.WriteLine(Michael.Id);

            Console.Read();
        }
    }
}
