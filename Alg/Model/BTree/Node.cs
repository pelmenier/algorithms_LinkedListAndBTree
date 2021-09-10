using System;
using System.Diagnostics.CodeAnalysis;

namespace Alg.Model.BTree
{
    public class Node<T> : IComparable<T>
        where T : IComparable, IComparable<T>
    {
        public T Data { get; private set; }

        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        
        public void Add(T data)
        {
            var node = new Node<T>(data);
            if(data.CompareTo(Data) == -1)
            {
                if(Left == null)
                {
                    Left = node;
                }                
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if(Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }       

        public int CompareTo(object obj)
        {           
            if(obj is Node<T> item)
            {
                return Data.CompareTo(obj);               
            }
            else
            {
                throw new ArgumentException("не совпадение типов");
            }
        }

        public int CompareTo([AllowNull] T other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Data.ToString();
        }        
    }
}
