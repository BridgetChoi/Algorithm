using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter04.Sections.section01
{
    class LeftChildRightSibling
    {
        private class LCRSnode
        {
            public LCRSnode leftChild;
            public LCRSnode rightSibling;
            public char Data;
        }

        public LeftChildRightSibling() { }
        ~LeftChildRightSibling() { }

        public void LeftChildRightSiblingProgress()
        {
            // 노드 생성
            LCRSnode objRoot    = CreateTreeNode('A');
            LCRSnode objNodeB = CreateTreeNode('B');
            LCRSnode objNodeC = CreateTreeNode('C');
            LCRSnode objNodeD = CreateTreeNode('D');
            LCRSnode objNodeE = CreateTreeNode('E');
            LCRSnode objNodeF = CreateTreeNode('F');
            LCRSnode objNodeG = CreateTreeNode('G');
            LCRSnode objNodeH = CreateTreeNode('H');
            LCRSnode objNodeI  = CreateTreeNode('I');
            LCRSnode objNodeJ = CreateTreeNode('J');
            LCRSnode objNodeK = CreateTreeNode('k');

            // 노드 연결
            AddChildNode(objRoot, objNodeB);
            AddChildNode(objNodeB, objNodeC);
            AddChildNode(objNodeB, objNodeD);
            AddChildNode(objNodeD, objNodeE);
            AddChildNode(objNodeD, objNodeF);
            AddChildNode(objRoot, objNodeG);
            AddChildNode(objNodeG, objNodeH);
            AddChildNode(objRoot, objNodeI);
            AddChildNode(objNodeI, objNodeJ);
            AddChildNode(objNodeJ, objNodeK);

            // 출력
            //PrintTree(objRoot, 0);
            PrintTreetoLevel(objRoot, 0, 0);

            string strKeep = "N";
            Console.WriteLine();
            while (!string.IsNullOrEmpty(strKeep))
            {
                Console.Write("Press Enter to return..");
                strKeep = Console.ReadLine();
            }
            
        }

        private LCRSnode CreateTreeNode(char newData)
        {
            LCRSnode objNode = new LCRSnode();
            objNode.leftChild     = null;
            objNode.rightSibling = null;
            objNode.Data          = newData;

            return objNode;
        }

        private void AddChildNode(LCRSnode objParent, LCRSnode objChild)
        {
            if(objParent.leftChild == null)
            {
                objParent.leftChild = objChild;
            }
            else
            {
                LCRSnode objTemp = objParent.leftChild;
                while(objTemp.rightSibling != null)
                {
                    objTemp = objTemp.rightSibling;
                }

                objTemp.rightSibling = objChild;
            }
        }

        private void PrintTree(LCRSnode objTree, int Depth)
        {
            int i = 0;
            for (i = 0; i < Depth; i++)
            {
                Console.Write("     ");
            }

            Console.WriteLine(objTree.Data);

            if(objTree.leftChild != null)
            {
                PrintTree(objTree.leftChild, Depth + 1);
            }

            if(objTree.rightSibling != null)
            {
                PrintTree(objTree.rightSibling, Depth);
            }
        }

        private void PrintTreetoLevel(LCRSnode objTree, int level, int count)
        {
            if(level == count)
            {
                Console.Write(objTree.Data);
            }

            if (objTree.leftChild != null)
            {
                PrintTreetoLevel(objTree.leftChild, level, count + 1);
            }

            if (objTree.rightSibling != null)
            {
                PrintTreetoLevel(objTree.rightSibling, level, count);
            }
        }
    }
}
