using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal sealed class MyLinkedListNode
    {
        public MyLinkedListNode? Next { get; set; }
        public MyLinkedListNode? Preveouse { get; set; }
        internal object Item { get; private set; }

        public MyLinkedListNode(object obj)
        {
            Item = obj;
        }
        public MyLinkedListNode(MyLinkedListNode preveouse, object obj)
        {
            Preveouse = preveouse;
            Item = obj;
        }
        public MyLinkedListNode(MyLinkedListNode preveouse, MyLinkedListNode next, object obj)
        {
            Next = next;
            Preveouse = preveouse;
            Item = obj;
        }

    }
}
