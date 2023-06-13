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
        public object[] Arr { get; protected set; }
        protected uint _size = 4;

        public virtual bool Contains(object obj)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Arr[i].Equals(obj))
                    return true;
            }
            return false;
        }

        public virtual object[] ToArray()
        {
            object[] arr = new object[Count];
            
            for (int i = 0; i < Count; i++)
                arr[i] = Arr[i];

            return arr;
        }

        public virtual void Clear()
        {
            for (uint i = 0; i < Count; i++)
                Arr[i] = null;
            _count = 0;
        }

        protected virtual object[] ForEach()
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
