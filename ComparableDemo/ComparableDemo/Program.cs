using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ComparableDemo
{
    class Box : IComparable //WHY is box underlined? we forgot about gethashcode... (don't forget...)
    {
        private int Width;
        private int Height;
        private string name;

        public Box(int w, int h, string name)
        {
            Width = w;
            Height = h;
            this.name = name;
        }
        
        //review of equals override
        public override bool Equals(object obj)
        {
            if (!(obj is Box b)) return false;
            return Width == b.Width && Height == b.Height;
        }
        
        //specialized (OPTIONAL) version of equals
        //benefit: saves a conversion (faster)
        public bool Equals(Box other)
        {
            if (other == null) return false;
            return Width == other.Width && Height == other.Height;
        }
        
        public int CompareTo(object obj)
        {
            if (!(obj is Box b)) 
                throw new ArgumentException($"Box:CompareTo:{nameof(obj)} - not a valid box");
            return (Width * Height).CompareTo(b.Width * b.Height); //comparison in ascending order
            //LEVERAGE int's compareto
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Box a, b, c, d;
            a = new Box(33, 1,"a");
            b = a;
            c = new Box(2, 2,"c");
            d = new Box(2, 2,"d");
            Console.WriteLine($"a.Equals(b): {a.Equals(b)}"); //true
            Console.WriteLine($"c.Equals(b): {c.Equals(b)}"); //f
            Console.WriteLine($"c.Equals(d): {c.Equals(d)}"); //F //if overridden, T
            Console.WriteLine($"c.Equals(2): {a.Equals(2)}");

            List<Box> list = new List<Box>();
            list.Add( a );
            list.Add( b );
            list.Add(c); 
            list.Add(d);

            list.Sort();

            Console.WriteLine("We have our list of boxes");
            list.Remove(d);
            Console.WriteLine("We removed d");
            //why do we override equals when we could simply put in an overloaded equals
            //just handling the type we care about?
            //BECAUSE extension methods rely on the OVERRIDE equals one, and it won't play well
            //if you simply overload instead of override!

            //Comparison
            Console.WriteLine($"Box A Compared to Box C: {a.CompareTo(c)}"); //-??
            Console.ReadKey();

        }
    }
}
