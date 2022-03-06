using System;
/*
 * Sarah Mehri
 * console program linkedlist
 * 10/13/2021
 */

namespace ConsoleAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList");
            LinkedList list = new LinkedList();
            list.AddToEnd(3);
            list.AddToEnd(2);
            list.AddToEnd(5);
            list.AddToEnd(8);
            list.Print();
            Console.WriteLine();
            Console.WriteLine("adding in sorted order");
            LinkedList list2 = new LinkedList();
            list2.AddSorted(2);
            list2.AddSorted(10);
            list2.AddSorted(5);
            list2.AddSorted(3);
            Console.WriteLine("befor delete");    
            list2.Print();
            Console.WriteLine("deleting the last elemnent ");
            list2.delete();
            list2.Print();




        }
    }
}
