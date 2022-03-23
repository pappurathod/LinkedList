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
            Console.WriteLine("Remove from Linked List" + temp.data);
        }
    }
}
