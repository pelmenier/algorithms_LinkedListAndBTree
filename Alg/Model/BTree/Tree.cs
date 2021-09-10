using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Alg.Model.BTree
{
    public class Tree<T> : IComparable<T>, IComparable
        where T: IComparable, IComparable<T>
    {
        public Node<T> Root { get; private set; }

        public int Count { get; private set; }

        public void Add(T data)
        {
            if(Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo([AllowNull] T other)
        {
            throw new NotImplementedException();
        }

        public List<T> Preorder()
        {            
            if(Root == null)
            {
                return new List<T>(); 
            }
            return Preorder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();
            if(node != null)
            {
                list.Add(node.Data);

                if(node.Left != null)
                {
                    list.AddRange(Preorder(node.Left)); 
                }
                
                if(node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }
            return list;
        }

        public List<T> TraverseBFS(Node<T> node)
        {
            var list = new List<T>();
            var queue = new Queue<Node<T>>();
            queue.Enqueue(node);
            list.Add(node.Data);
            while(queue.Count > 0)
            {               
                node = queue.Dequeue();
                Console.Write(node.Data + " ");
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                    list.Add(node.Left.Data);
                }                       

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                    list.Add(node.Right.Data);
                }                 
            }
            return list;
        }
    }
}
