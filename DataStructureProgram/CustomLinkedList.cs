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
        public void AddLast(int data)
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
            Console.WriteLine("{0} added into list", newNode.data);
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} added into list", newNode.data);
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        public void InsertAt(int data, int index)
        {
            
            if (index < 0)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            if (index==0)
            {
                AddFirst(data);
            }
            else
            {
                Node newNode = new Node(data);
                Node temp = head; 
                for (int i=0; i<index-1;i++) 
                {
                     temp= temp.next;
                }
                newNode.next = temp.next; 
                temp.next = newNode; 
            }
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
        public void PopLast()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty please add nodes");
            }
            else
            {
                if (temp.next == null)
                {
                    int data = temp.data;
                    temp = null;
                    Console.WriteLine("{0} Node is removed sucessfully", data);
                }
                //second node not equal to null
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                int lastDeletedNode = temp.next.data;
                temp.next = null;
                Console.WriteLine("{0} node is removed sucessfully", lastDeletedNode);
            }
        }
        public int Search(int data)
        {
            Node temp = head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("list is empty please add nodes");
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        Console.WriteLine("\n{0} node is present in list\n", temp.data);
                        return count;
                    }
                    temp = temp.next;
                    count++;
                }
                Console.WriteLine("\n{0} node is not present in Linked list\n", data);
            }
            return count;
        }
        public void Display()
        {
            Console.WriteLine("\nDisplaying Elements\n");
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty.");
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
