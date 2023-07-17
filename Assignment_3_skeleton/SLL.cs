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
            if (IsClear)
                return false;
            
            var current = Head;
            while (current.Next != null)
            {
                if (current.Data == data)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        //Removes element at index from list, reducing the size.
        //parameter index Index of element to remove.
        //throws exception IndexOutOfBoundsException Thrown if index is negative or past the size - 1.
        public void Delete(int index)
        {
            if(IsClear)
                throw new NullReferenceException("List is empty"); 
            
            if (index > Count)
                throw new IndexOutOfRangeException("Index provided is greater than the size of the list");
            
            if (index < 0)
                throw new IndexOutOfRangeException("Index must be greater than -1");

            var current = Head;
            
            if (index == 0)
            {
                Head = current.Next;
                
            }
            else
            {
                for (var i = 0; i < index; i++)
                {
                    current
                }
            }

        }
        
        public int IndexOf(object data)
        {
            if (IsClear)
                return -1;

            var current = Head;
            var index = 0;
            while (current.Next != null)
            {
                if (current.Data == data)
                {
                    return index;
                }
        
                index++;
                current = current.Next;
            }
            
            return -1;
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
            if (IsClear)
                throw new NullReferenceException("List is empty");

            if (index > Count)
                throw new IndexOutOfRangeException("Index provided is greater than the size of the list");
            
            if (index < 0)
                throw new IndexOutOfRangeException("Index must be greater than -1");

            if (index == 0)
            {
                var newNode = new Node(data, null);
                Head = newNode;
            }
            else
            {
                var current = Head;
                for (var i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                current.Next = new Node(data, current.Next?.Next);
            }
            
        }

        public object Retrieve(int index)
        {
            if (index < 0)
                throw new IndexOutOfRangeException("Index must be greater than -1");

            if (IsClear)
            {
                throw new NullReferenceException("List is empty!");
            }

            var current = Head;
            
            for (var i = 0; i < index; i++)
            {
                current = current.Next ?? throw new IndexOutOfRangeException("Index out of range");
            }

            return current.Data;
        }

        public int Size()
        {
            return Count;
        }
    }
}
