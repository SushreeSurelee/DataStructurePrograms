using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram
{
    class LinkedListQueue
    {
        public Node head;
        CustomLinkedList list = new CustomLinkedList();
        public void Enqueue(int item)
        {
            Node newNode = new Node(item);
            if(this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted into Queue", newNode.data);
        }
        public void EnqueueByLinkedList(int item)
        {
            list.Append(item);
        }
        public void Display()
        {
            Console.WriteLine("\nDisplaying Elements in Queue\n");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
        public void DisplayByLinkedList()
        {
            list.Display();
        }
    }
}
