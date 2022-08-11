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
            Console.WriteLine("Please choose number to execute\n1:Linked List.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CustomLinkedList linkedList = new CustomLinkedList();
                    linkedList.Append(56);
                    linkedList.Append(70);
                    linkedList.Display();
                    linkedList.InsertAt(30, 1);
                    linkedList.Display();
                    linkedList.Search(30);
                    linkedList.Search(80);
                    break;
            }
            Console.ReadLine();
        }
    }
}
