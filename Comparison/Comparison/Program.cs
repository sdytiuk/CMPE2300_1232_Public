using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    internal class Thing  : IComparable
    {
        public int X { get; private set; }
        public Thing(int iVal)
        {
            X = iVal;
        }

        internal static int MyReverseThingCompare(Thing t1, Thing t2)
        {
            //both null means they are the same
            if (t1 == null && t2 == null) return 0;
            //t1 is null but t2 is not null; null is always less than something
            if (t1 == null) return -1;
            //t1 is not null but t2 is null... 
            if (t2 == null) return 1;
            //return t1.X - t2.X;
            //what if we do t1.compareto(t2)??
            //return t1.CompareTo(t2);
            return -t1.X.CompareTo(t2.X); //CALLS INT's COMPARETO
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Thing t)) throw new ArgumentException("Something");
            //return this.CompareTo(t); //call the method you are in recursively with no end... stackoverflow
            return -Thing.MyReverseThingCompare(this, t);
        }

        public override string ToString()
        {
            return X.ToString();
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Thing a, b;
            a = new Thing(1);
            b = new Thing(2);

            List<Thing> list = new List<Thing>();
            list.Add(a);
            list.Add(b);
            list.Add(new Thing(5));
            list.Add(new Thing(4));

            list.Sort(); //CompareTo
            foreach (Thing t in list)
            {
                Console.WriteLine(t.ToString() + ", ");
            }
            list.Sort(Thing.MyReverseThingCompare);
            foreach (Thing t in list)
            {
                Console.WriteLine(t.ToString() + ", ");
            }


            Console.WriteLine(a.CompareTo(b));

            Console.ReadLine();

        }
    }
}
