using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Node
    {
        public int data { get; set; }
        public Node sagdugum { get; set; }
        public Node soldugum { get; set; }
        public Node(int data)
        {
            this.data = data;
            sagdugum = null;
            soldugum = null;
        }
    }
}
