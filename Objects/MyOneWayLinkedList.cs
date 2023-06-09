using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyOneWayLinkedList : MyArray
    {
        public object? First { get { return Arr[0]; } }
        public object? Last { get { return Count > 0 ? Arr[Count - 1] : null; } }
        public MyOneWayLinkedList()
        {
            Arr = new object[_size];
        }
        public void Add(object item)
        {
            if (Count + 1 > _size)
            {
                _size *= 2;
                Arr = ForEach();
            }
            Arr[_count++] = item;
        }
        public void AddFirst(object item)
        {
            if (Count + 1 > _size)
            {
                _size *= 2;
                Arr = ForEach();
            }
            object[] objects = new object[_size];
            objects[0] = item;
            for (int i = 1; i < Count + 1; i++)
                objects[i] = Arr[i - 1];
            Arr = objects;
        }
        public void Insert(int index, object item)
        {
            if (index < Count && index >= 0)
                Arr[index] = item;
            else { throw new IndexOutOfRangeException(); }
        }
    }
}
