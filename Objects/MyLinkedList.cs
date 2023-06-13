using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Objects
{
    internal class MyLinkedList : MyOneWayLinkedList
    {
        internal new MyLinkedListNode? _head;
        public new MyLinkedListNode? First { get { return _head; } }
        public new MyLinkedListNode? Last { get; private set; }

        public new void Add(object item)
        {
            if (_head == null)
            {
                _head = new MyLinkedListNode(item);
                Last = _head;
                _count++;
            }
            else
            {
                MyLinkedListNode current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new MyLinkedListNode(current, item);
                Last = current.Next;
                _count++;
            }
        }

        public override void AddFirst(object item)
        {
            if (_head == null)
            {
                _head = new MyLinkedListNode(item);
                Last = _head;
                _count++;
            }
            else
            {
                MyLinkedListNode current = _head;
                _head = new MyLinkedListNode(null ,current , item);
                current.Preveouse = _head;
                _count++;
            }
        }

        public override void Insert(int index, object item)
        {
            if (_head == null)
            {
                _head = new MyLinkedListNode(item);
                Last = _head;
                _count++;
            }
            else if (index <= Count)
            {
                MyLinkedListNode current = _head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                current.Preveouse.Next = new MyLinkedListNode(current.Preveouse, current, item);
                current.Preveouse = current.Preveouse.Next;
                _count++;
            }
        }

        public void Remove(object item)
        {
            if (_head != null)
            {
                MyLinkedListNode? current = _head;
                for (int i = 0; i < Count; i++)
                {
                    if (current.Item.GetHashCode() == item.GetHashCode())
                    {
                        if (current == _head)
                            RemoveFirst();
                        else if (current == Last)
                            RemoveLast();
                        else
                        {
                            current.Preveouse.Next = current.Next.Preveouse;
                            current.Next = null;
                            current.Preveouse = null;
                            _count--;
                        }
                    }
                    current = current.Next;
                }
            }
        }
        public void RemoveFirst()
        {
            if (_head != null)
            {
                _head.Next.Preveouse = null;
                _head = _head.Next;
                _count--;
            }
        }
        public void RemoveLast()
        {
            if (_head != null)
            {
                Last.Preveouse.Next = null;
                Last = Last.Preveouse;
                _count--;
            }
        }

        public override bool Contains(object obj)
        {
            if (_head != null)
            {
                MyLinkedListNode? current = _head;
                for (int i = 0; i < Count; i++)
                {
                    if (current.Item.GetHashCode() == obj.GetHashCode())
                        return true;
                    current = current.Next;
                }
            }
            return false;
        }

        public override object[] ToArray()
        {
            if (_head != null)
            {
                object[] Arr = new object[Count];
                MyLinkedListNode? current = _head;
                for (int i = 0; i < Count; i++)
                {
                    Arr[i] = current.Item;
                    current = current.Next;
                }
                return Arr;
            }
            return null;
        }

        public override void Clear()
        {
            MyLinkedListNode? current = _head;
            while(current != null)
            {
                MyLinkedListNode temp = current;
                current = current.Next;
                temp.Next = null;
                temp.Preveouse = null;
            }
            _head = null;
            Last = null;
            _count = 0;
        }
    }
}
