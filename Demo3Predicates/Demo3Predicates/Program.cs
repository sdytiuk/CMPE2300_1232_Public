using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Predicates
{
    internal class Program
    {
        public static bool isBigger(int iVal)
        {
            return iVal > 5;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i< 10; i++)
            {
                list.Add(rand.Next(0,10));
            }

            foreach (int i in list)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine(list.Find(new Predicate<int>(isBigger)));

            Console.WriteLine(list.Find(isBigger));

            Console.ReadKey();
        }
    }
}
