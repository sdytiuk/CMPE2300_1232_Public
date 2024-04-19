using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CCube x = new CCube();
            Console.WriteLine("is X an IVolume?" + (x is IVolume).ToString()); //we'll see
            Console.WriteLine("is X an IComparable?" + (x is IComparable).ToString()); //we'll see
            Console.WriteLine("is X a Shape?" + (x is Shape).ToString()); //expect TRUE

            Console.WriteLine((x as IVolume)?.myNumber);
            Console.WriteLine((x as ICloneable)?.ToString());
            Console.WriteLine("The End");
            Console.ReadLine();

        }
    }

    //interface for things that have a volume
    interface IVolume
    {
        //declare properties and methods that are implicitly abstract
        int myNumber { get; }
        double GetVolume(); //implicitly public and abstract
    }


    internal class Shape
    {
        public string name;
    }

    internal class CCube : Shape, IVolume, IComparable
    {
        public double GetVolume()
        {
            return 1; //need to do actual calculation from members
        }

        public int myNumber { get { return 111; } }

        public int CompareTo(object other)
        {
            return 0;
        }
    }
}
