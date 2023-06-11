using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyTreeNode
    {
        public MyTreeNode? Left;
        public MyTreeNode? Right;
        public int Item;
        
        public MyTreeNode(int item)
        {
            Item = item;
        }
    }
}
