using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacklar
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            stack mystack = new stack(10);
            mystack.Push(15);
            mystack.Push(23);
            mystack.Push(43);
            mystack.Push(45);
            mystack.Print();
            Console.WriteLine();
            mystack.PrintCount();
            mystack.PrintTop();
          Node b=  mystack.Pop();
            if (b != null)
            {
                //b null dönerse program hata alıcağından böyle yazmamız gerek
            }
            else { Console.WriteLine("stack zaten  boş"); }
           Console.WriteLine( "stack : " );
            mystack.Print();

            Console.ReadLine();
        }
    }
}
