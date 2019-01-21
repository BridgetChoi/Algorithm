using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter06.Search
{
    class BinarySearchTree
    {
        private class BinarySearchTreeNode
        {
            public BinarySearchTreeNode objLeft;
            public BinarySearchTreeNode objRight;
            public int intData;
        }

        private BinarySearchTreeNode createNode(int intData)
        {
            BinarySearchTreeNode objNew = new BinarySearchTreeNode();
            objNew.objLeft = null;
            objNew.objRight = null;
            objNew.intData = intData;

            return objNew;
        }

        private void destroyNode(ref BinarySearchTreeNode objTree)
        {
            if(objTree.objRight != null)
            {
                destroyNode(ref objTree.objRight);
            }
            if(objTree.objLeft != null)
            {
                destroyNode(ref objTree.objLeft);
            }

            objTree.objRight = null;
            objTree.objLeft = null;
        }

        private BinarySearchTreeNode searchNode(ref BinarySearchTreeNode objTree, int intTarget)
        {
            if(objTree == null)
            {
                return null;
            }

            if(objTree.intData == intTarget)
            {
                return objTree;
            }
            else if(objTree.intData > intTarget)
            {
                return searchNode(ref objTree.objLeft, intTarget);
            }
            else
            {
                return searchNode(ref objTree.objRight, intTarget);
            }
        }

        private BinarySearchTreeNode searchMinNode(ref BinarySearchTreeNode objTree)
        {
            if(objTree == null)
            {
                return null;
            }

            if(objTree.objLeft == null)
            {
                return objTree;
            }
            else
            {
                return searchMinNode(ref objTree.objLeft);
            }
        }

        private void insertNode(ref BinarySearchTreeNode objTree, ref BinarySearchTreeNode objChild)
        {
            if(objTree.intData < objChild.intData)
            {
                if(objTree.objRight == null)
                {
                    objTree.objRight = objChild;
                }
                else
                {
                    insertNode(ref objTree.objRight, ref objChild);
                }
            }
            else if(objTree.intData > objChild.intData)
            {
                if(objTree.objLeft == null)
                {
                    objTree.objLeft = objChild;
                }
                else
                {
                    insertNode(ref objTree.objLeft, ref objChild);
                }
            }
        }

        private BinarySearchTreeNode removeNode(ref BinarySearchTreeNode objTree, ref BinarySearchTreeNode objParent, int intTarget)
        {

        }
    }
}
