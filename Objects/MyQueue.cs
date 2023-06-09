using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyQueue : MyArray
    {        
        public MyQueue()
        {
            Arr = new object[_size];
        }
        public void Enqueue(object obj)
        {
            if (Count + 1 > _size)
            {
                _size *= 2;
                Arr = ForEach();
            }
            Arr[_count++] = obj;
        }
        public object Dequeue()
        {
            object obj = Arr[0];
            Arr[0] = null;
            Arr = ForEach();
            _count--;
            return obj;
        }
        public object Peek()
        {
            return Arr[0];
        }


    }
}
