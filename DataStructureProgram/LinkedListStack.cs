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
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n{0} is in top of the stack", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            int deleteNode = this.top.data;
            Console.WriteLine("{0} is deleted from the stack", deleteNode);
            this.top = this.top.next;
        }
        public void Empty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        public void Display()
        {
            Console.WriteLine("\nDisplaying Nodes in Stack\n");
            Node temp = this.top;
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
        }
    }
}
