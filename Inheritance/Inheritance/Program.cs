using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base x = new Base(99);
            Console.WriteLine(x);
            Console.WriteLine("********End X********");

            Derived y = new Derived();
            Console.WriteLine(y);

            Console.WriteLine("********End Y********");
            Derived z = new Derived(55);
            Console.WriteLine(z);
            z.Show(); //this uses DERIVED show()

            //to use the PARENT show... UPCAST
            ((Base)z).Show();

            Console.WriteLine("********End Z********");
            Console.ReadLine();
        }
    }

    class Base
    {
        private int _inum = 1;
        public int Num {  get { return _inum; } }

        //CTOR
        public Base() 
        {
            Console.WriteLine("We invoked default CTOR");
        }

        public Base (int iVal)
        {
            _inum = iVal;
            Console.WriteLine("Base (int) CTOR invoked.");
        }
        public override string ToString()
        {
            return "Base: " + Num.ToString();
        }

        public void Show()
        {
            Console.WriteLine("Base Show");
        }

    }

    class Derived : Base
    {
        int _iDNum = 77;
        public Derived():base() 
        { 
            _iDNum++;
            Console.WriteLine("Derived Default CTOR Invoked");
        }

        public Derived(int iDNum):base(iDNum)
        {
            _iDNum++;
        }

        public override string ToString()
        {
            return "Derived: " + _iDNum.ToString() + ", " + Num;
        }

        public new void Show()
        {
            Console.WriteLine("Derived Show");
        }
    }
}
