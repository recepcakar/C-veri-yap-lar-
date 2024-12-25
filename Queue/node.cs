using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class node
    {
        public  int  data    { get; set; }
        public node next { get; set; }
        public node(int data) {
            this.data = data;
            this.next = null;
        }
    }
}
