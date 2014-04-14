using System;
using System.Collections.Generic;
using System.Linq;

namespace SinglyLinkedListNode
{
    /// <summary>
    /// Question 1.2
    /// </summary>
    class Program
    {
        private static int pos = 7;

        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(7);
            list.AddLast(3);
            list.AddLast(78);
            list.AddLast(96);
            list.AddLast(1);
            list.AddLast(5);
            list.AddLast(9);
            list.AddLast(52);
            list.AddLast(67);
            list.AddLast(91);
            list.AddLast(55);

            Console.WriteLine(list.ElementAt(list.Count() - pos));
        }
    }
}

