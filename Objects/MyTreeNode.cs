using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyTreeNode
    {
        public MyTreeNode? Parent;
        public MyTreeNode? Left;
        public MyTreeNode? Right;
        public int Item;
        
        public MyTreeNode(int item)
        {
            Item = item;
        }
        public MyTreeNode(int item, MyTreeNode? parent)
        {
            Item = item;
            Parent = parent;
        }

    }
}
