using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Queue
{
    public class Queue
    {
        private node head = null;
        private node tail = null;
        private int size;
        public Queue()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public Queue(int data)
        {
            node yeninode = new node(data);
            head = yeninode;
            tail = yeninode;
            size = 1;
        }
        public void Enqueue(int data) //ekleme
        {
            node yeninode = new node(data);
            if (size == 0)
            {
                head = yeninode;
                tail = yeninode;
            }
            else {
                tail.next = yeninode;
                tail = yeninode;
            }
            size++;

        }
        public void Print() {
            Console.WriteLine(" Queue içeriği ");
            Console.WriteLine(" ----------------- ");
            node temp = head;
            if (temp == null)
            {
                Console.WriteLine("liste zaten boş");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        public void PrintHead() {

            Console.WriteLine(" head",head.data);
        }
        public void PrintSize()
        {

            Console.WriteLine(size);
        }
        public void PrintTail()
        {

            Console.WriteLine(tail.data);
        }
        public node Dequeue()
        {
            node silinecek = head;
            if (size == 0)
            {
                Console.WriteLine("liste zaten boş");

            }

            if (size == 1)
            {
                head = null;
                tail = null;

            }
            else
            {

                head = head.next;
                silinecek.next = null;

            }
            size--;
            return silinecek;

        }
        public Boolean isempty()
        {
            if (size == 0) 
                return true;
            else
                return false;
        }
    }
}
