using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter05.Sort.Sections.section_03
{
    class InsertSortDoubleLinkedList
    {
        private class Node
        {
            public int intData;
            public Node objPrev;
            public Node objNext;
        }

        public void InsertSortLinkedListProgress()
        {
            Node objDataSetHead = null;
            Node objDataSetTail = null;

            SetNode(ref objDataSetHead, ref objDataSetTail, CreateNode(6));
            SetNode(ref objDataSetHead, ref objDataSetTail, CreateNode(4));
            SetNode(ref objDataSetHead, ref objDataSetTail, CreateNode(2));
            SetNode(ref objDataSetHead, ref objDataSetTail, CreateNode(3));
            SetNode(ref objDataSetHead, ref objDataSetTail, CreateNode(1));
            SetNode(ref objDataSetHead, ref objDataSetTail, CreateNode(5));

            InsertSortDoubleLinked(ref objDataSetHead, ref objDataSetHead, 1);

            PrintDataSet(objDataSetHead);

            string strKeep = "N";
            Console.WriteLine();
            while (!string.IsNullOrEmpty(strKeep))
            {
                Console.Write("Press Enter to return..");
                strKeep = Console.ReadLine();
            }
        }

        private Node CreateNode(int Data)
        {
            Node objNewNode = new Node();
            objNewNode.intData = Data;
            objNewNode.objPrev = null;
            objNewNode.objPrev = null;

            return objNewNode;
        }

        private void SetNode(ref Node objHead, ref Node objTail, Node objNew)
        {
            if (objHead == null && objTail == null)
            {
                objHead = objNew;
            }
            else if (objHead != null && objTail == null)
            {
                objTail = objNew;
                objTail.objPrev = objHead;
                objHead.objNext = objTail;
            }
            else
            {
                Node objTemp = objTail;

                objNew.objPrev = objTemp;
                objTemp.objNext = objNew;
                objTail = objNew;
            }
        }

        private void InsertSortDoubleLinked(ref Node objNodes, ref Node objHead, int intIndex)
        {
        }

        private void PrintDataSet(Node objNode)
        {
            Node objTemp = objNode;
            while(objTemp.objNext != null)
            {
                Console.Write(objTemp.intData);
                Console.Write("     ");

                objTemp = objTemp.objNext;
            }
            Console.WriteLine();
        }
    }
}
