using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyStack : MyArray
    {
        public new int Count { get { return arr.Count; } }

        private readonly MyList arr;
        public MyStack()
        {
            arr = new MyList();
        }
        public void Push(object obj) => arr.Add(obj);

        public object Pop()
        {
            if (arr.Count > 0)
            {
                object obj = arr.Arr[arr.Count - 1];
                arr.RemoveAt(arr.Count - 1);
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
