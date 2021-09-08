using Alg.Model;
using System;
using System.Collections.Generic;

namespace Alg
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            list.Add(3);
            list.Add(3);
            list.UpdateItem(3, 7);
            var list2 = new Model.LinkedList<int>();
            list2.Add(22);
            list2.Add(11);
            list.UnionLinkedList(list2);
            list.UpdateItem(4, 1111);

            foreach(var item in list)
            {
                Console.WriteLine(item + " ");
            }            
            
            Console.ReadLine();
        }
    }
}
