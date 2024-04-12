using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<cBase> list = new List<cBase>();
            list.Add(new cBase());
            list.Add(new CDerived());

            list.ForEach(x => x.Who());

            Console.ReadLine();
        }
    }

    class cBase
    {
        public virtual void Who()
        {
            Console.WriteLine("Who in base!");
        }
    }

    class CDerived : cBase
    {
        public override void Who()
        {
            Console.WriteLine("Who in CDerived");
        }
    }
}
