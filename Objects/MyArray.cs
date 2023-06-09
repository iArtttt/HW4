using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    abstract class MyArray
    {
        protected uint _count = 0;
        public int Count { get { return (int)_count; } }
        protected object[] Arr;
        protected uint _size = 4;
        //public void Add(object item)
        //{
        //    if (Count + 1 > _size)
        //    {
        //        _size *= 2;
        //        Arr = ForEach();
        //    }
        //    Arr[_count++] = item;
        //}
        public bool Contains(object obj)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Arr[i].GetHashCode() == obj.GetHashCode())
                    return true;
            }
            return false;
        }
        public object[] ToArray()
        {
            object[] arr = new object[Count];
            
            for (int i = 0; i < Count; i++)
                arr[i] = Arr[i];

            return arr;
        }
        public void Clear()
        {
            for (uint i = 0; i < Count; i++)
                Arr[i] = null;
            _count = 0;
        }
        protected object[] ForEach()
        {
            object[] arr = new object[_size];

            for (int i = 0; i < Count; i++)
            {
                if (Arr[i] != null)
                    arr[i] = Arr[i];
                else
                { 
                    for (int j = i; j < Count - 1; j++)
                        arr[j] = Arr[j + 1];
                    return arr;
                }
            }

            return arr;
        }
    }
}
