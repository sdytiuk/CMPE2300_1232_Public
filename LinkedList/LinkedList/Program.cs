using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            LinkedList<int> aLinked = new LinkedList<int>();
            aLinked.AddFirst(0);
            aLinked.AddLast(99);

            //AddAfter...
            LinkedListNode<int> node = aLinked.AddAfter(aLinked.First, 2);

            //addbefore
            node = aLinked.AddBefore(node, 5);

            foreach (int i in aLinked)
            {
                Console.Write(i + ", ");
            }

            //assign the node to the second spot
            node = aLinked.First.Next;

            for (int i = 0; i < 10; i++)
                node = aLinked.AddAfter(node, random.Next(10));

            foreach (int i in aLinked)
            {
                Console.Write(i + ", ");
            }

            //POINTER IS SHARED = aLinked is the one linked list
            LinkedList<int> dup = aLinked;

            dup.First.Value = -88;
            //aLinked.First.Value = -99;
            //we duplicated/cloned the linkedlist and now there's 2
            LinkedList<int> copy = new LinkedList<int>(aLinked);
            List<int> list = new List<int>(aLinked);
            list = aLinked.ToList();
            list[5] = -99999999;
            copy.First.Next.Value = -525600;
            Console.WriteLine("TESTING:");
            foreach (int i in aLinked)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("Node Traversal:");
            LinkedListNode<int> traverseNode = aLinked.First;
            while (traverseNode != null)
            {
                Console.Write(traverseNode.Value.ToString() + ", ");
                traverseNode = traverseNode.Next;
            }

            Console.WriteLine("Node Traversal Backwards!:");
            for (LinkedListNode<int> i = aLinked.Last; i != null; i = i.Previous) 
            {
                Console.Write(i.Value.ToString() + ": ");
            }
            Console.ReadKey();
        }
    }
}
