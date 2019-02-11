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

        public void BinarySearchTreeProgress()
        {
            // 노드 생성
            BinarySearchTreeNode objTree = createNode(123);
            BinarySearchTreeNode objNode = null;

            // 트리에 노드 추가
            insertNode(ref objTree, createNode(22));
            insertNode(ref objTree, createNode(9918));
            insertNode(ref objTree, createNode(424));
            insertNode(ref objTree, createNode(17));
            insertNode(ref objTree, createNode(3));

            insertNode(ref objTree, createNode(98));
            insertNode(ref objTree, createNode(34));
            insertNode(ref objTree, createNode(760));
            insertNode(ref objTree, createNode(317));
            insertNode(ref objTree, createNode(1));

            InorderPrintTree(objTree);
            Console.WriteLine();
            Console.WriteLine("removing 98 ... ");

            BinarySearchTreeNode objRemove = removeNode(ref objTree, null, 98);
            destroyNode(ref objRemove);

            InorderPrintTree(objTree);
            Console.WriteLine();
            Console.WriteLine("Inserting 111 ... ");

            insertNode(ref objTree, createNode(111));
            InorderPrintTree(objTree);
            Console.WriteLine();

            string strKeep = "N";
            Console.WriteLine();
            while (!string.IsNullOrEmpty(strKeep))
            {
                Console.Write("Press Enter to return..");
                strKeep = Console.ReadLine();
            }
        }

        private void InorderPrintTree(BinarySearchTreeNode objTree)
        {
            if(objTree == null)
            {
                return;
            }

            // 왼쪽 하위 트리 출력 
            InorderPrintTree(objTree.objLeft);

            // 루트 노드 출력 
            Console.Write(objTree.intData);
            Console.Write("     ");

            // 오른쪽 하위 트리 출력 
            InorderPrintTree(objTree.objRight);
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

        private void insertNode(ref BinarySearchTreeNode objTree, BinarySearchTreeNode objChild)
        {
            if(objTree.intData < objChild.intData)
            {
                if(objTree.objRight == null)
                {
                    objTree.objRight = objChild;
                }
                else
                {
                    insertNode(ref objTree.objRight, objChild);
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
                    insertNode(ref objTree.objLeft, objChild);
                }
            }
        }

        private BinarySearchTreeNode removeNode(ref BinarySearchTreeNode objTree, BinarySearchTreeNode objParent, int intTarget)
        {
            BinarySearchTreeNode objRemoved = null;

            if(objTree == null)
            {
                return null;
            }

            if(objTree.intData > intTarget)
            {
                objRemoved = removeNode(ref objTree.objLeft, objTree, intTarget);
            }
            else if(objTree.intData < intTarget)
            {
                objRemoved = removeNode(ref objTree.objRight, objTree, intTarget);
            }
            else
            {
                // 목표값을 찾은 경우 
                objRemoved = objTree;

                // 잎 노드인 경우 바로 삭제 
                if(objTree.objLeft == null && objTree.objRight == null)
                {
                    if(objParent.objLeft == objTree)
                    {
                        objParent.objLeft = null;
                    }
                    else
                    {
                        objParent.objRight = null;
                    }
                }
                else
                {
                    // 양쪽 자식이 다 있는 경우
                    if(objTree.objLeft != null && objTree.objRight != null)
                    {
                        BinarySearchTreeNode objMinNode = searchMinNode(ref objTree.objRight);
                        objRemoved = removeNode(ref objTree, null, objMinNode.intData);
                        objTree.intData = objMinNode.intData;
                    }
                    else
                    {
                        BinarySearchTreeNode objTemp = null;
                        if(objTree.objLeft != null)
                        {
                            objTemp = objTree.objLeft;
                        }
                        else
                        {
                            objTree = objTree.objRight;
                        }

                        if(objParent.objLeft == objTree)
                        {
                            objParent.objLeft = objTemp;
                        }
                        else
                        {
                            objParent.objRight = objTemp;
                        }
                    }
                }
            }

            return objRemoved;
        }
    }
}
