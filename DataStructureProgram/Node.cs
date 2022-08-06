using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram
{
    public class Node
    {
        public int data;
        public Node next = null; 
        public Node(int data)
        {
            this.data = data;
        }
    }
}
