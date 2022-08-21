using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram
{
    class LinkedListStack
    {
        public Node top;
        public void Push(int stackData)
        {
            //creating a link between newnode and where top is pointing
            //then pointing top towards the new node
            //new node is inserted on the top
            Node newNode = new Node(stackData);
            if(this.top!=null)
            {
                newNode.next = this.top; //newnode with hold the address reference of top element
            }
            this.top = newNode; //top will point to new element
            Console.WriteLine("New Node {0} is added to stack", newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("\nDisplaying Nodes in Stack\n");
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty.");
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
            Console.WriteLine();
        }
    }
}
