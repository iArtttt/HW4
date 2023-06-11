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
            else          
                SetPosition(item);
           
        }
        private void SetPosition(int item)
        {

            MyTreeNode current = Root;
            while (current.Left != null && current.Right != null)
            {
                if (current.Item > item)
                {
                    if (current.Left == null)
                    {
                        current.Left = new MyTreeNode(item, current);
                        _count++;
                    }
                    else
                        current = current.Left;
                }
                else if (current.Item < item)
                {
                    if (current.Right == null)
                    {
                        current.Right = new MyTreeNode(item, current);
                        _count++;
                    }
                    else
                        current = current.Right;
                }
            }



        }
        public bool Contains(int item)
        {
            if (Root != null)
            {
                MyTreeNode current = Root;
                while (current.Left != null && current.Right != null)
                {
                    if (current.Item == item)
                        return true;
                    if (current.Item > item)
                    {
                        if (current.Left == null)
                            return false;
                        else
                            current = current.Left;
                    }
                    else
                    {
                        if (current.Right == null)
                            return false;
                        else
                            current = current.Right;
                    }
                }
            }
            return false;
        }
        public int[] ToArray()
        {
            if (Root != null)
            {

                MyTreeNode current = Root;
                int[] array = new int[Count];
                while (current.Left != null)
                    current = current.Left;
                for (int i = 0; i < Count; i++)
                {
                    array[i] = current.Item;
                    if(current.Right != null)
                        current = current.Right;



                }
                




            }
            return null;


        }
        public void Clear()
        {
            Root.Right = null;
            Root.Left = null;
            Root = null;

            _count = 0;
        }
    }
}
