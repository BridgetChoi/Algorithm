using System;

namespace Algorithm.Chapter04.Sections.section02
{
    class SimpleBinaryTree
    {
        private class tagBinaryTreeNode
        {
            public tagBinaryTreeNode objLeft;
            public tagBinaryTreeNode objRight;
            public char charData;
        }

        public SimpleBinaryTree() { }
        ~SimpleBinaryTree() { }

        public void SimpleBinaryTreeProcess()
        {
            Console.WriteLine(">> 노드 생성");
            tagBinaryTreeNode objA = this.SBT_CreateNode('A');
            tagBinaryTreeNode objB = this.SBT_CreateNode('B');
            tagBinaryTreeNode objC = this.SBT_CreateNode('C');
            tagBinaryTreeNode objD = this.SBT_CreateNode('D');
            tagBinaryTreeNode objE = this.SBT_CreateNode('E');
            tagBinaryTreeNode objF = this.SBT_CreateNode('F');
            tagBinaryTreeNode objG = this.SBT_CreateNode('G');

            Console.WriteLine(">> 트리에 노드 추가");
            objA.objLeft = objB;
            objB.objLeft = objC;
            objB.objRight = objD;

            objA.objRight = objE;
            objE.objLeft = objF;
            objE.objRight = objG;

            Console.WriteLine(">> 전위 트리 출력 ");
            this.SBT_PreorderPrintTree(objA);
            Console.WriteLine();

            Console.WriteLine(">> 중위 트리 출력 ");
            this.SBT_InorderPrintTree(objA);
            Console.WriteLine();

            Console.WriteLine(">> 후위 트리 출력 ");
            this.SBT_PostorderPrintTree(objA);
            Console.WriteLine();

            Console.WriteLine(">> 트리 소멸 ");
            this.postDestroyTree(objA);
            Console.WriteLine();

            string strKeep = "N";
            Console.WriteLine();
            while (!string.IsNullOrEmpty(strKeep))
            {
                Console.Write("Press Enter to return..");
                strKeep = Console.ReadLine();
            }
        }

        private tagBinaryTreeNode SBT_CreateNode(char Data)
        {
            tagBinaryTreeNode objNew = new tagBinaryTreeNode();
            objNew.objLeft = null;
            objNew.objRight = null;
            objNew.charData = Data;

            return objNew;
        }

        private void DestroyNode(tagBinaryTreeNode objNode)
        {
            objNode = null;
        }

        #region 전위순회
        private void SBT_PreorderPrintTree(tagBinaryTreeNode objNode)
        {
            if(objNode == null)
            {
                return;
            }

            Console.Write(objNode.charData);
            Console.Write("     ");

            SBT_PreorderPrintTree(objNode.objLeft);
            SBT_PreorderPrintTree(objNode.objRight);
        }
        #endregion 전위순회

        #region 중위순회
        private void SBT_InorderPrintTree(tagBinaryTreeNode objNode)
        {
            if(objNode == null)
            {
                return;
            }

            SBT_InorderPrintTree(objNode.objLeft);

            Console.Write(objNode.charData);
            Console.Write("     ");

            SBT_InorderPrintTree(objNode.objRight);
        }
        #endregion 중위순회

        #region 후위순회
        private void SBT_PostorderPrintTree(tagBinaryTreeNode objNode)
        {
            if(objNode == null)
            {
                return;
            }

            SBT_PostorderPrintTree(objNode.objLeft);
            SBT_PostorderPrintTree(objNode.objRight);

            Console.Write(objNode.charData);
            Console.Write("     ");
        }
        #endregion 후위순회

        // 트리의 제거는 잎부터 할수밖에 없음.
        #region 후위순회 소멸
        private void postDestroyTree(tagBinaryTreeNode objNode)
        {
            if (objNode == null) return;

            postDestroyTree(objNode.objLeft);
            postDestroyTree(objNode.objRight);
            DestroyNode(objNode);
        }
        #endregion 후위순회 소멸
    }
}
