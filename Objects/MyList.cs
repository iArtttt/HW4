using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyList
    {
        private uint _count = 0;
        public int Count { get { return (int)_count; } }
        public uint Capasity { get; private set; } = 10;
        public object[] Arr; 
        public MyList() 
        {
            Arr = new object[Capasity];
        } 
        public MyList(uint startCapasity) 
        {
            Capasity = startCapasity;
            Arr = new object[Capasity];
        }
        public void Add(object item)
        {
            if (Count + 1 > Capasity)
            {
                Capasity *= 2;
                Arr = new object[Capasity];
            }
            Arr[_count++] = item;
        }
        public void Insert(int index, object item)
        {
            Arr[index] = item;
        }
        public int IndexOf(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Arr[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Contains(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Arr[i] == item)
                    return true;
            }
            return false;
        }
        public void Remove(object obj)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Arr[i] == obj)
                {
                    Arr[i] = null;
                }
            }
        }
        public void RemoveAt(int index)
        {
            Arr[index] = null;
        }
        public void Clear()
        {
            Arr = null;
        }
    }
}
