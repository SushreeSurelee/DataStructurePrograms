using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Program\n");
            Console.WriteLine("Please choose number to execute\n1:Linked List.\n2:Stack");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CustomLinkedList linkedList = new CustomLinkedList();
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    int element = linkedList.Search(30);
                    linkedList.InsertAt(40, element + 1);
                    linkedList.Display();
                    break;
                case 2:
                    LinkedListStack stack = new LinkedListStack();
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    stack.Empty();
                    stack.Display();
                    break;
            }
            Console.ReadLine();
        }
    }
}
