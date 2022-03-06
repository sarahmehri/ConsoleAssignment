using System;
/*
 * Sarah Mehri
 * 10/13/2021
 * Node class
 */
namespace ConsoleAssignment
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            this.data = i;
            next = null;

        }
        public Node()
        {

        }

        //
        public void Print()
        {
            Console.Write("|" + data + "|->");

            //using recursive method
           if(next != null)
            {
                next.Print();
            }
        }

        //adding element at the end of our list
        public void AddToEnd(int num)
        {
            if(next == null)
            {
                next = new Node(num);
            }
            else
            {
                next.AddToEnd(num);
            }
        }
        //adding elements in sorted order
        
        public void AddSorted(int num)
        {
            if(next == null)
            {
                next = new Node(num);
            }
            else if(num < next.data)
            {
                Node tem = new Node(num);
                tem.next = this.next;
                this.next = tem;
            }
            else
            {
                next.AddSorted(num);
            }
        }
       
    }
}
