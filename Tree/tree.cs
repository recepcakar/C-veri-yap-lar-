using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class tree
    {
        public Node root { get; set; }

        public tree()
        {
            root = null;
        }

        public tree(int data)
        {
            root = new Node(data);
        }

        public bool InsertNode(int data)
        {
            Node yeninode = new Node(data);
            if (root == null)
            {
                root = yeninode;
                return true;
            }
            else
            {
                Node tmp = root;
                while (true)
                {
                    if (yeninode.data == tmp.data)
                    {
                        return false; // Aynı değer varsa eklenmez
                    }
                    if (yeninode.data < tmp.data)
                    {
                        if (tmp.soldugum == null)
                        {
                            tmp.soldugum = yeninode;
                            return true;
                        }
                        tmp = tmp.soldugum;
                    }
                    else if (yeninode.data > tmp.data)
                    {
                        if (tmp.sagdugum == null)
                        {
                            tmp.sagdugum = yeninode;
                            return true;
                        }
                        tmp = tmp.sagdugum;
                    }
                }
            }
        }

        public void PreorderSearch(Node node)
        {
            Console.Write(node.data + " , ");
            if (node.soldugum != null)
            {
                PreorderSearch(node.soldugum);
            }
            if (node.sagdugum != null)
            {
                PreorderSearch(node.sagdugum);
            }
        }
        public Node DfsPreorder(Node node,int data) 
        { 
            if(node == null || node.data == data)
            {
                return node;
            }
            if (data < node.data)
            {
               return  DfsPreorder(node.soldugum,data);
            }
            else
            { return DfsPreorder(node.sagdugum,data); 
            }
        }
        public void DfsPostorder(Node node)
        {
           
            if (node.soldugum != null)
            {
                DfsPostorder(node.soldugum);
            }
            if (node.sagdugum != null)
            {
                DfsPostorder(node.sagdugum);
            }
            Console.Write(node.data + " , ");
        }
        public void DfsInorder(Node node)
        {
           
            if (node.soldugum != null)
            {
                DfsInorder(node.soldugum);       // tüm solu ziyaret ediyoruz
            }
            Console.Write(node.data + " , ");  
            if (node.sagdugum != null)
            {
                DfsInorder(node.sagdugum);    // sonra sağı ziyarey ediyryz
            }
      
        }
        public void BreadthFirstSearch()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count>0) 
            {
                Node node = queue.Dequeue();
                Console.WriteLine(node.data);
                if (node.soldugum != null)
                {
                    queue.Enqueue(node.soldugum);
                }
                if(node.sagdugum != null) { queue.Enqueue(node.sagdugum); }
            }
        }

    }
}
