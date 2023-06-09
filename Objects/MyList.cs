using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyList : MyArray
    {
        public uint Capasity { get { return _size; } }
        public MyList() 
        {
            Arr = new object[_size];
        } 
        public MyList(int startCapasity) 
        {
            _size = (uint)Math.Abs(startCapasity);
            Arr = new object[_size];
        }

        public void Insert(int index, object item)
        {
            if (index < Count && index >= 0)
                Arr[index] = item;
            else { throw new IndexOutOfRangeException(); }
        }
        public int IndexOf(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                object obj = Arr[i];

                if (obj.GetHashCode() == item.GetHashCode())
                    return i;
            }
            return -1;
        }

        public void Remove(object obj)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Arr[i].GetHashCode() == obj.GetHashCode())
                {
                    Arr[i] = null;
                    Arr = ForEach();
                    _count--;
                    return;
                }
            }
        }
        public void RemoveAt(int index)
        {
            if (index < Capasity && index >= 0) 
            {
                Arr[index] = null;
                Arr = ForEach();
                _count--;
            }
            else { throw new IndexOutOfRangeException(); }
        }
        public void Reverse()
        {
            int j = 0;
            object[] arr = new object[_size];
            for (int i = Count - 1; i >= 0; i--)
                arr[j++] = Arr[i];
            Arr = arr;
        }
    }
}
