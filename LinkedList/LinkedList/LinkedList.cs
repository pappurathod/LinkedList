using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        public Node Head;
        public Node Tail;

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine("linked list as follows");

            }
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.Write(" ->");
                }
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }

        public void AddNodeatStart(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }

        public void DeleteNodeatFirst()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
            Console.WriteLine("Remove from Linked List = " + temp.data);
        }

        public void DeleteEndNode()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            else
            {
                if (Head == null)
                {
                    Console.WriteLine("Nothing To Delete");
                    return;
                }
                Node temp = Head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Console.WriteLine("Remove from Linked List = " + temp.next.data);
                temp.next = null;
            }
           
        }
        public bool search(int data)
        {
            Node temp = this.Head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public void AddSpecificNode(Node node, int pos)
        {
            
            if (pos < 1)
            {
                Console.WriteLine("select correct position");
            }
            else if (pos == 1)
            {
                node.next = Head;
                Head= node;
            }
            else
            {
                Node temp = Head;
                for(int i = 1; i < pos-1; i++)
                {
                    if(temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    node.next = temp.next;
                    temp.next = node;
                }
                else
                {
                    Console.WriteLine("Invalid Position");
                }
            }           
        
        }
    }
}
