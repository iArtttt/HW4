using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Objects
{
    internal class MyTree
    {
        private int _count = 0;
        public int Count { get { return _count; } }
        public MyTreeNode? Root { get; private set; }
        public void Add(int item)
        {
            if (Root == null)
            {
                Root = new MyTreeNode(item);
                _count++;
            }
            else if(!Contains(item))
            {
                SetPosition(Root, item);
                _count++;
            }     
           
        }

        private MyTreeNode SetPosition(MyTreeNode current, int item)
        {
            if(current == null)
                return new MyTreeNode(item);
            else
            {
                if (current.Item > item)
                    current.Left = SetPosition(current.Left, item);
                else
                    current.Right = SetPosition(current.Right,item);
            }
            return current;
        }        
        public bool Contains(int item) => Contains(Root, item);
        private bool Contains(MyTreeNode current, int item)
        {
            if (current != null)
            {
                if (current.Item == item)
                    return true;
                if (current.Item > item)
                    return Contains(current.Left, item);
                else    
                    return Contains(current.Right, item);
            }
            return false;
        }

        public int[] ToArray()
        {
            if (Root == null)
                return null;
            int i = 0;
            int[] array = new int[Count];
            ToArray(Root, array, ref i);
            return array;

        }

        private void ToArray(MyTreeNode current, int[] ints, ref int i)
        {
            if (current != null)
            {                
                ToArray(current.Left, ints, ref i);
                ints[i++] = current.Item;
                ToArray(current.Right, ints, ref i);
            }
        }

        public void Clear()
        {
            Root = null;
            _count = 0;
        }

        public void PrintTree() => PrintTree(Root);

        private void PrintTree(MyTreeNode current)
        {
            if (current != null)
            {
                PrintTree(current.Left);
                Console.WriteLine(current.Item);
                PrintTree(current.Right);
            }
        }
    }
}
