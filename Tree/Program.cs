using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tree tree = new tree(52);
            tree.InsertNode(27);
            tree.InsertNode(15);
            tree.InsertNode(30);
            tree.InsertNode(78);
            tree.InsertNode(65);
            tree.InsertNode(53);
            tree.PreorderSearch(tree.root);
            Console.WriteLine();
            tree.DfsPostorder(tree.root);
            Console.WriteLine();
            tree.DfsInorder(tree.root);
            tree.BreadthFirstSearch();
            Console.ReadLine();
        }
    }
}
