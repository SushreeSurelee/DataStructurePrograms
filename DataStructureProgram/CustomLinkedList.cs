using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram
{
    class CustomLinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} added into linked list", newNode.data);
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} added into linked list", newNode.data);
        }
        public void Append(int data)
        {
            Add(data);
        }
        public Node Insert(int data, int position)
        {
            if(position < 1)
                Console.WriteLine("Invalid position");
            
            Node newNode = new Node(data);
            if (position==1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                while(position-- != 0)
                {
                    if (position == 1)
                    {
                        newNode.next = head.next;
                        head.next = newNode;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position is out of range");
            }
            return head;
        }
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty please add nodes");
            }
            else
            {
                int removeItem = head.data;
                head = head.next;
                Console.WriteLine("\n{0} is sucessfully removed from Linked list.", removeItem);
            }
        }

        public void Display()
        {
            Console.WriteLine("\nDisplaying Nodes\n");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty.");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
    }
}
