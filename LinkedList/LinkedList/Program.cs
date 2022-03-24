using System;
namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();  //UC1
            Node node1 = new Node(22);
            Node node2 = new Node(23);
            Node node3 = new Node(24);

            linkedList.AddNode(node1);   //UC2
            linkedList.AddNode(node2);
            linkedList.AddNode(node3);
            linkedList.Display();

            Node node4 = new Node(25);  //UC3
            linkedList.AppendNode(node4);
            linkedList.Display();

            Node node5 = new Node(26);        //UC4
            linkedList.AddNodeatStart(node5);
            linkedList.Display();

            linkedList.DeleteNodeatFirst();   //UC5
            linkedList.Display();

            linkedList.DeleteEndNode();  //UC6
            linkedList.Display();
            
            Console.WriteLine("Enter Number want to Search");  //UC7
            int data = int.Parse(Console.ReadLine());
            bool res = linkedList.search(data);
            if (res == true)
                Console.WriteLine("Data is found");            
            else            
                Console.WriteLine("Data is not found");
            


            Node node6 = new Node(50);    //UC8
            linkedList.Display();
            Console.WriteLine("select position to add new Element");
            data = int.Parse(Console.ReadLine());
            linkedList.AddSpecificNode(node6, data);
            linkedList.Display();

            Console.WriteLine("Select node for deletion");  //UC9
            data = int.Parse(Console.ReadLine());
            linkedList.DeleteSpecificNode(data);
            linkedList.Display();
        }
    }
}