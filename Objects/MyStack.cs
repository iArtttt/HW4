using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyStack : MyArray
    {
        public MyStack()
        {
            Arr = new object[_size];
        }
        public void Push(object obj)
        {
            if (Count + 1 > _size)
            {
                _size *= 2;
                Arr = ForEach();
            }
            Arr[_count++] = obj;
        }
        public object Pop()
        {
            if (_count > 0)
            {
                object obj = Arr[_count - 1];
                Arr[_count - 1] = null;
                _count--;
                return obj;
            }
            return null;
        }
        public object Peek()
        {
            return Arr[_count - 1];
        }
    }
}
