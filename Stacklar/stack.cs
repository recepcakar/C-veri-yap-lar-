using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacklar
{
    internal class stack
    {
        private Node top;
        private int count;
        public stack()
        {
            top = null;
            count = 0;
        }
        public stack(int data)
        {
            Node yeninode = new Node(data);
            top = yeninode;
            count = 1;


        }
        public void Push(int data)
        {
            Node yeninode = new Node(data);
            if (count == 0)
            {
                top = yeninode;
            }
            else
            {
                yeninode.next = top;
                top = yeninode;
            }
            count++;
        }
        public void Print()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + "-");
                temp = temp.next;
            }

        }
        public void PrintCount()
        {
            Console.WriteLine("count : " + count);
        }
        public void PrintTop()
        {
            Console.WriteLine("top : " + top.data);
        }
        public Node Pop()
        {
           
            if (count == 0)
            {
                return top;
            }
            else
            {
               Node cikarilcak= top;    
                top=top.next;
                cikarilcak.next = null;
                count--;
                return cikarilcak;

            }
        }
        public Boolean isempty() { 
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

