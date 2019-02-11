using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter06.Search
{
    class RedBlackTree
    {
        private class RedBlackTreeNode
        {
            public RedBlackTreeNode objParent;
            public RedBlackTreeNode objLeft;
            public RedBlackTreeNode objRight;
            public int intData;
            public enum Color { Red, Black };
        }
    }
}
