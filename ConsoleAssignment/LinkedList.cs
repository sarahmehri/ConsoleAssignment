using System;
/*
 * Sarah Mehri
 * 10/14/2021
 * linkedlist class
 */
namespace ConsoleAssignment
{
    public class LinkedList
    {
        private Node headNode;



        public LinkedList()
        {
            headNode = null;
        }

        public void AddToEnd(int num)
        {
            if(headNode == null)
            {
                headNode = new Node(num);

            }
            else
            {
                headNode.AddToEnd(num);
            }
        }

        //printing element

        public void Print()
        {
            if( headNode != null)
            {
                headNode.Print();
            }
            
        }

        //adding to beginning of our list
        public void AddToBeginning(int num)
        {
            if(headNode == null)
            {
                headNode = new Node(num);
            }
            else
            {
                Node temp = new Node(num);
                temp.next = headNode;
                headNode = temp;
            }
            

        }

        //adding to our list by sort
        public void AddSorted(int num)
        {
            if(headNode == null)
            {
                headNode = new Node(num);
            }
            else if(num < headNode.data)
            {
                AddToBeginning(num);
            }
            else
            {
                headNode.AddSorted(num);
            }
            
        }


        //Delete last node of the list
        public void delete()
        {
            if (this.headNode != null)
            {
                if (this.headNode.next == null)
                {
                    this.headNode = null;
                }
                else
                {
                    Node temp = new Node();
                    temp = this.headNode;
                    while (temp.next.next != null)
                        temp = temp.next;
                    Node lastNode = temp.next;
                    temp.next = null;
                    lastNode = null;
                }
            }
        }
    }
}
