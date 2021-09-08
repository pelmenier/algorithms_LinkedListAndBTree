using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Alg.Model
{
    public class LinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;            
            Count = 0;
        }

        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(item);
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);

            if(Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                item.IndexItem = Count;
                Count++;
            }
            else
            {
                SetHeadAndTail(item);
            }
        }

        public Item<T> UpdateItem(int index, T data)
        {
            if(Head != null)
            {
                var id = --index;
                var current = Head;
                while(current != null)
                {
                    if(current.IndexItem == id)
                    {
                        current.Data = data;
                        return current;
                    }
                    current = current.Next;
                }
            }
            return null;
        }

        public void UnionLinkedList(LinkedList<T> list)
        {
            if(Tail != null && list.Head != null)
            {
                Count += list.Count;
                var firstListTail = Tail;
                var current = list.Head;                
                var index = firstListTail.IndexItem;
                firstListTail.Next = current;

                while (current != null)
                {     
                    current.IndexItem = ++index;
                    current = current.Next;                     
                }
            }           
        }

        private void SetHeadAndTail(Item<T> item)
        {
            Head = item;
            Tail = item;
            item.IndexItem = Count;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
