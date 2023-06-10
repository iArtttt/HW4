using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyOneWayLinkedList 
    {
        private int _count = 0;
        internal MyOneWayLinkedListNode? _head;
        public int Count { get { return _count; } }
        public MyOneWayLinkedListNode? First { get { return _head; } }
        public MyOneWayLinkedListNode? Last { get; private set; }

        public void Add(object item)
        {
            if (_head == null)
            {
                _head = new MyOneWayLinkedListNode(item);
                Last = _head;
                _count++;
            }
            else
            {
                MyOneWayLinkedListNode current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new MyOneWayLinkedListNode(item);
                Last = current.Next;
                _count++;
            }
        }
        public void AddFirst(object item)
        {
            if (_head == null)
            {
                _head = new MyOneWayLinkedListNode(item);
                Last = _head;
                _count++;
            }
            else
            {
                MyOneWayLinkedListNode current = _head;
                _head = new MyOneWayLinkedListNode(current, item);
                _count++;
            }
        }
        public void Insert(int index, object item)
        {
            if (_head == null)
            {
                _head = new MyOneWayLinkedListNode(item);
                Last = _head;
                _count++;
            }
            else if (index <= Count) 
            {
                MyOneWayLinkedListNode current = _head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                current.Next = new MyOneWayLinkedListNode(current.Next, item);
                _count++;
            }
        }
        public bool Contains(object obj)
        {
            if (_head != null)
            {
                MyOneWayLinkedListNode? current = _head;
                for (int i = 0; i < Count; i++)
                {
                    if (current.item.GetHashCode() == obj.GetHashCode())
                        return true;
                    current = current.Next;
                }
            }
            return false;
        }
        public object[] ToArray()
        {
            if (_head != null)
            {
                object[] Arr = new object[Count];
                MyOneWayLinkedListNode? current = _head;
                for (int i = 0; i < Count; i++)
                {
                    Arr[i] = current.item;
                    current = current.Next;
                }
                return Arr;
            }
            return null;
        }
        public void Clear()
        {
            MyOneWayLinkedListNode? current = _head;
            while (current != null)
            {
                MyOneWayLinkedListNode temp = current;
                current = current.Next;
                temp.Next = null;
            }
            _head = null;
            Last = null;
            _count = 0;
        }
    }
}
