using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter01.Sections.section03
{
    public class Chapter01_section03
    {
        public class tagNodeCircle
        {
            public int Data;
            public tagNodeCircle PrevNode;
            public tagNodeCircle NextNode;
        }

        public tagNodeCircle Head;
        public tagNodeCircle Tail;

        public Chapter01_section03() { }

        public void Chapter01_section03_Progress()
        {
            string strIndex = chapter01Selction03Index();
            setChapter01_Selction03_functions(strIndex);
        }

        public string chapter01Selction03Index()
        {
            Console.Clear();
            Console.WriteLine("[ CHAPTER 01 > SELCTION 03 ]");

            Console.WriteLine("1. 노드 추가");
            Console.WriteLine("2. 리스트 출력");
            Console.WriteLine("3. 노드 삽입");
            Console.WriteLine("4. 모든 노드 제거");
            Console.WriteLine("5. 뒤로");
            Console.WriteLine("6. 종료");
            Console.WriteLine("---------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();

            return strIndex;
        }

        public void setChapter01_Selction03_functions(string strIndex)
        {
            switch(strIndex)
            {
                case "1" :
                    CreateNode();
                    break;
                case "2" :
                    PrintList();
                    break;
                case "3" :
                    InsertNode();
                    break;
                case "4" :
                    RemoveNode();
                    break;
                case "5" :
                    Chapter01.Chapter01_Index _chapter01Index = new Chapter01_Index();
                    _chapter01Index.Chapter01_Progress();
                    break;
                case "6" :
                    Environment.Exit(0);
                    break;
                default :
                    break;
            }
        }

        #region switch case 1
        private void CreateNode()
        {
            string strLoop = "Y";
            while (strLoop.Equals("Y"))
            {
                Console.Write("생성 할 노드 값(정수) 입력 >> ");
                int intData = Convert.ToInt32(Console.ReadLine());

                tagNodeCircle _newnode = new tagNodeCircle();
                _newnode = CDLL_CreateNode(intData);
                CDLL_AppendNode(_newnode);

                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }

            Chapter01_section03_Progress();
        }
        // 노드 생성
        public tagNodeCircle CDLL_CreateNode(int intData)
        {
            tagNodeCircle _newnode = new tagNodeCircle();
            _newnode.Data = intData;
            _newnode.NextNode = null;
            _newnode.PrevNode = null;

            return _newnode;
        }
        // 노드 추가
        public void CDLL_AppendNode(tagNodeCircle NewNode)
        {
            if(Head == null)
            {
                Head = NewNode;
                Head.NextNode = Head;
                Head.PrevNode = Head;
            }
            else
            {
                tagNodeCircle _tail = Head.PrevNode;

                _tail.NextNode.PrevNode = NewNode;
                _tail.NextNode = NewNode;

                NewNode.NextNode = Head;
                NewNode.PrevNode = _tail;
            }
        }
        #endregion switch case 1

        #region switch case 2
        public void PrintList()
        {
            tagNodeCircle _curr = Head;
            int intCnt = 0;
            while (_curr != null)
            {
                Console.WriteLine("List[" + intCnt.ToString() + "] : " + _curr.Data.ToString());
                _curr = _curr.NextNode;
                intCnt++;

                if(_curr == Head)
                {
                    break;
                }
            }

            if (intCnt.Equals(0))
            {
                Console.WriteLine("리스트 없음");
            }

            Console.Write("enter to exit");
            Console.ReadLine();

            Chapter01_section03_Progress();
        }
        #endregion switch case 2

        #region switch case 3
        public void InsertNode()
        {
            string strLoop = "Y";
            while (strLoop.Equals("Y"))
            {
                Console.Write("생성 할 노드 값(정수) 입력 >> ");
                int intData = Convert.ToInt32(Console.ReadLine());

                tagNodeCircle _newnode = new tagNodeCircle();
                _newnode = CDLL_CreateNode(intData);

                Console.Write("삽입 할 위치 >> ");
                int intIndex = Convert.ToInt32(Console.ReadLine());

                CDLL_InsertNode(_newnode, intIndex);

                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }

            Chapter01_section03_Progress();
        }

        public void CDLL_InsertNode(tagNodeCircle NewNode, int Index)
        {
            if(Index.Equals(0))
            {
                tagNodeCircle _tail = Head.PrevNode;
                _tail.NextNode = NewNode;
                NewNode.PrevNode = _tail;

                Head.PrevNode = NewNode;
                NewNode.NextNode = Head;
                Head = NewNode;
            }
            else
            {
                tagNodeCircle _curr = Head;
                int intCnt = 0;
                Index = Index - 1;

                while(true)
                {
                    if (intCnt.Equals(Index))
                    {
                        NewNode.NextNode = _curr.NextNode;
                        NewNode.PrevNode = _curr.NextNode.PrevNode;

                        _curr.NextNode.PrevNode = NewNode;
                        _curr.NextNode = NewNode;

                        break;
                    }
                    else if (!(intCnt.Equals(0)) && _curr == Head)
                    {
                        CDLL_AppendNode(NewNode);
                        break;
                    }

                    _curr = _curr.NextNode;
                    intCnt++;
                }
            }
        }
        #endregion switch case 3

        #region switch case 4
        public void RemoveNode()
        {
            tagNodeCircle _curr = Head;

            while (_curr != null)
            {
                _curr.PrevNode.NextNode = Head.NextNode;
                _curr.NextNode.PrevNode = Head.PrevNode;

                Head.NextNode = null;
                Head.PrevNode = null;
                Head = null;

                _curr = _curr.NextNode;
            }

            Chapter01_section03_Progress();
        }
        #endregion switch case 4
    }
}
