using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Objects
{
    internal class MyOneWayLinkedListNode
    {
        public MyOneWayLinkedListNode? Next { get; set; }
        internal object item;

        public MyOneWayLinkedListNode(object obj)
        {
            item = obj;
        }
        public MyOneWayLinkedListNode(MyOneWayLinkedListNode next, object obj)
        {
            Next = next;
            item = obj;
        }        
    }
}
