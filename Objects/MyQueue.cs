using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyQueue : MyArray
    {
        public new int Count { get { return arr.Count; } }

        private readonly MyList arr;
        public MyQueue()
        {
            arr = new MyList();
        }
        public void Enqueue(object obj) => arr.Add(obj);

        public object Dequeue()
        {
            if (arr.Count > 0)
            {
                object obj = arr.Arr[0];
                arr.RemoveAt(0);
                return obj;
            }
            return null;
        }

        public object Peek()
        {
            if (arr.Count > 0) return arr.Arr[arr.Count - 1];
            return null;
        }

        public override bool Contains(object obj) => arr.Contains(obj);

        public override object[] ToArray() => arr.ToArray();

        public override void Clear() => arr.Clear();

    }
}
