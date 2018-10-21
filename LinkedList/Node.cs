using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }
        public Node(int data)
        {
            this.Data = data;
            Next = null;

        }
    }
}
