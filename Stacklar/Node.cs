﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacklar
{
    internal class Node
    {
        public int data { get; set; }
        public Node next { get; set; }
        public Node(int data) {
        
        this.data = data;
        this.next = null;
        }
    }
}
