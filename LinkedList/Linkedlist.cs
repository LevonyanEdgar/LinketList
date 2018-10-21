using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Linkedlist
    {
        private Node first;
        private Node last;
        private int listCount = 0;
        public Linkedlist() { }
        public void AddItem(int data)
        {
            Node newItem = new Node(data);
            if (first==null)
            {
                first = newItem;
                last = first;

            }
            else
            {
                Node travers = first;
                while (travers.Next!=null)
                {
                    travers = travers.Next;
                }
                travers.Next = newItem;
                last = travers.Next;
            }
            listCount++;


        }
        public void RemoveFirst()
        {
            Node newFirst = first.Next;
            first = null;
            first = newFirst;
            listCount--;
            DisplayList();


        }
        public void RomoveLast()
        {
            int index = 1;
            Node traversel = first;
            while (traversel.Next!=null)
            {
                traversel = traversel.Next;
                index++;
                if (index==listCount-1)
                {
                    break;
                }

            }
            last = traversel;
            traversel.Next = null;
            listCount--;
            DisplayList();
        }
        public void RemoeveItem(int removeValue)
        {
            Node traversel = first;
            Node nextnext = null;
            while (traversel.Next!=null)
            {
                nextnext = traversel.Next.Next;
                if (traversel.Next.Data==removeValue)
                {
                    traversel.Next = null;
                    traversel.Next = nextnext;
                    break;
                }
                else
                {
                    traversel = traversel.Next;
                }
               
            }
            listCount--;
            DisplayList();
        }

        private void DisplayList()
        {
            Node currrent = first;
            while (currrent!=null)
            {
                Console.WriteLine($"{currrent.Data}");
                currrent = currrent.Next;
                if (currrent==null)
                {
                    return;
                }
            }
        }
    }
}
