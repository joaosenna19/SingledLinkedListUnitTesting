using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {

        public Node Head { get; set; }
        public int Count { get; set; }
        public bool IsClear => Count == 0;

        public SLL()
        {
            Head = null;
            Count = 0;
        }
        public void Append(object data)
        {

            var newNode = new Node(data, null);
            
            if (IsClear)
            {
                Head = newNode;
                
            }
            else
            {
                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            Count++;
            
        }

        public void Clear()
        {
            Head = null;
        }

        public bool Contains(object data)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object data)
        {
            throw new NotImplementedException();
        }

        public void Insert(object data, int index)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return IsClear;
        }

        public void Prepend(object data)
        {
            var current = Head;

            if (IsClear)
            {
                Head = new Node(data, null);
            }
            else
            {
                var newNode = new Node(data, Head);
                Head = newNode;
            }

            Count++;

        }

        public void Replace(object data, int index)
        {
            throw new NotImplementedException();
        }

        public object Retrieve(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index must be greater than -1");

            if (IsClear)
            {
                throw new NullReferenceException("List is empty!");
            }

            var current = Head;
            
            for (var i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Next.Data;
        }

        public int Size()
        {
            return Count;
        }
    }
}
