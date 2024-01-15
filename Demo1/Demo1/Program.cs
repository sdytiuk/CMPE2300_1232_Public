using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class sample
    {
        //fields
        private const int _iWidth = 800; //can never change; must be initialized now
        private readonly int _iHeight = 600; //may be modified in constructors
        private readonly int? _iDepth; //but if not modified in ctor, may have a default
        private int _iSpeed = 0; //regular instance member is most common

        //methods
        //instance vs static
        public void Shout()
        {
            for (int i=0; i<_iDepth; i++) {
                Console.WriteLine("Michael!");
            }
            
        }

        //make a DEFAULT CONSTRUCTOR
        public sample()
        {
            _iDepth = 50;
            _iSpeed = 10;
        }

        public sample(int depth):this()
        {
            _iDepth = depth;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int Griffin;
            //Console.Write(Griffin);
            sample s = new sample(5);
            s.Shout();
            Console.ReadLine();
        }
    }
}
