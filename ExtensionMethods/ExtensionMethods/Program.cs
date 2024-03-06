using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    //int DavidsQuestion = 5; Cannot have...

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
            /*
            //double value that you want to display as fixed 2 decimal places
            double x = 3.14159;
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.toFixed2());
            Console.WriteLine(x.toFixed3());
            string cole = "question";
            Console.WriteLine(cole);
            Console.WriteLine(cole.ColesNotes());
            */
            //using extension methods
            List<int> aList = new List<int>();
            List<int> bList = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                aList.Add(rnd.Next(10));
                bList.Add(rnd.Next(10));
            }

            Console.WriteLine("Both lists:");
            aList.ForEach(a => Console.Write(a.ToString()+","));
            Console.WriteLine();
            bList.ForEach(b => Console.Write(b.ToString() + ","));
            Console.WriteLine($"ASum = {aList.Sum()}") ;
            Console.WriteLine($"BSum = {bList.Sum()}");
            Console.WriteLine($"CombinedSum = {aList.Concat(bList).Sum()}");
            //how to use indexof and insert
            int num = 555;
            int where;
            where = aList.IndexOf(num); //returns -1 if number not found
            int numtoinsert = 99;
            if (where >= 0)
                aList.Insert(where, numtoinsert);
            aList.ForEach(a => Console.Write(a.ToString() + ","));
            Console.WriteLine();
            //filter out certain values (less than 3)
            IEnumerable<int> e = aList.Where(x => x < 3);
            e.ToList().ForEach(a => Console.Write(a.ToString() + ","));
            foreach (int i in e)
            { 
                Console.Write(i.ToString()); 
            }
            //aList.ForEach(a => Console.Write(a.ToString() + ",")); Note: AList WONT BE CHANGED

            //find common numbers
            Console.WriteLine();
            IEnumerable<int> common = aList.Intersect(bList);
            foreach (int i in common)
            {
                Console.Write(i.ToString()+",");
            }
            Console.ReadKey();
        }

        
    }
}
