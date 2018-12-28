﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter06.Search
{
    class SequentialSearch
    {
        private class Node
        {
            public int intData;
            public Node objNext;
        }

        public void SequentialSearchProgress()
        {
            Node objMoveToFrontDataSet = CreateNodes();
            PrintNode(objMoveToFrontDataSet);

            Console.WriteLine("After Sequential Search..");
            MoveToFront(ref objMoveToFrontDataSet, 48);
            PrintNode(objMoveToFrontDataSet);

            string strKeep = "N";
            Console.WriteLine();
            while (!string.IsNullOrEmpty(strKeep))
            {
                Console.Write("Press Enter to return..");
                strKeep = Console.ReadLine();
            }
        }

        private Node CreateNodes()
        {
            Node objHead     = null;
            Node objPrevious = null;
            int[] arrData   = {71, 5, 13, 1, 2, 48, 222, 136, 3, 15};
            for(int i = 0; i < arrData.Length; i++)
            {
                Node objNew = new Node();
                objNew.intData = arrData[i];
                objNew.objNext = null;

                if(i != 0)
                {
                    SetNodes(objPrevious, objNew);
                }
                else
                {
                    objHead = objNew;
                }
                objPrevious = objNew;
            }

            return objHead;
        }

        private void SetNodes(Node objPrev, Node objNew)
        {
            objPrev.objNext = objNew;
        }

        private Node MoveToFront(ref Node objHead, int intTarget)
        {
            Node objCurrent  = objHead;
            Node objPrevious = null;
            Node objMatch    = null;

            while(objCurrent != null)
            {
                if(objCurrent.intData == intTarget)
                {
                    objMatch = objCurrent;
                    if(objPrevious != null)
                    {
                        objPrevious.objNext = objCurrent.objNext;
                        objCurrent.objNext  = objHead;
                        objHead             = objCurrent;
                    }
                    break;
                }
                else
                {
                    objPrevious = objCurrent;
                    objCurrent  = objCurrent.objNext;
                }
            }

            return objMatch;
        }

        private void PrintNode(Node objNode)
        {
            while(objNode != null)
            {
                Console.Write(objNode.intData);
                Console.Write("     ");

                objNode = objNode.objNext;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
