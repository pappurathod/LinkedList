using System;
namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(22);
            Node node2 = new Node(23);
            Node node3 = new Node(24);

            linkedList.AddNode(node1);
            linkedList.AddNode(node2);
            linkedList.AddNode(node3);
            linkedList.Display();

            Node node4 = new Node(25);
            linkedList.AppendNode(node4);
            linkedList.Display();

            Node node5 = new Node(26);
            linkedList.AddNodeatStart(node5);
            linkedList.Display();

            linkedList.DeleteNodeatFirst();
            linkedList.Display();

            linkedList.DeleteEndNode();
            linkedList.Display();

            Console.WriteLine("Enter Number want to Search");
            int data = int.Parse(Console.ReadLine());
            bool res = linkedList.search(data);
            if (res == true)
            {
                Console.WriteLine("Data is found");
            }
            else
            {
                Console.WriteLine("Data is not found");
            }

        }
    }
}