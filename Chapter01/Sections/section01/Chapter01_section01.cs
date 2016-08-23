using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter01.Sections
{
    public class Chapter01_section01
    {
        // 1. 포인터 노트 클래스
        public class tagNode
        {
            public int Data;
            public tagNode NextNode;
        }

        int intCount = 0;

        section01.LinkedList _objLinkedList = new section01.LinkedList();

        public static tagNode head    = null;
        public static tagNode tail    = null;

        public Chapter01_section01() { }

        public void Chapter01_section01_Progress()
        {
            string strIndex = chapter01Selction01Index();
            setChapter01_Selction01_functions(strIndex);
        }

        public string chapter01Selction01Index()
        {
            Console.Clear();
            Console.WriteLine("[ CHAPTER 01 > SELCTION 01 ]");

            Console.WriteLine("1. 노드 생성");
            Console.WriteLine("2, Head 노드 추가");
            Console.WriteLine("3. 리스트 출력");
            Console.WriteLine("4. 특정 노드 뒤, 새 노드 삽입");
            Console.WriteLine("5. 모든 노드 제거");
            Console.WriteLine("6. 뒤로");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();

            return strIndex;
        }

        public void setChapter01_Selction01_functions(string strIndex)
        {
            switch(strIndex)
            {
                case "1" :
                    CreateNode();
                    break;
                case "2" :
                    CreateNodeHead();
                    break;
                case "3" :
                    PrintList();
                    break;
                case "4" :
                    InserNodeAfter();
                    break;
                case "5" :
                    RemoveAllNode();
                    break;
                case "6" :
                    Chapter01.Chapter01_Index _chapter01Index = new Chapter01_Index();
                    _chapter01Index.Chapter01_Progress();
                    break;
                default :
                    break;
            }
        }

        #region switch case 1
        // switch case 1
        public void CreateNode()
        {
            string strLoop = "Y";
            while (strLoop.Equals("Y"))
            {
                Console.Write("생성 할 노드 값(정수) 입력 >> ");
                int intData = Convert.ToInt32(Console.ReadLine());

                tagNode _newnode = new tagNode();
                _newnode = _objLinkedList.SLL_CreateNode(intData);
                SLL_AppendNode(_newnode);

                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }

            Chapter01_section01_Progress();
        }

        public void SLL_AppendNode(tagNode newNode)
        {
            // head 노드가 null 이면 새로운 노드가 head & tail
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                tagNode _tail = head;

                if (_tail.NextNode == null)
                {
                    head.NextNode = newNode;
                    tail = newNode;
                }
                else
                {
                    while (_tail.NextNode != null)
                    {
                        _tail = _tail.NextNode;
                    }

                    _tail.NextNode = newNode;
                    tail = newNode;
                }
            }
        }
        #endregion switch case 1

        #region switch case 2
        // switch case 2
        public void CreateNodeHead()
        {
            string strLoop = "Y";
            while(strLoop.Equals("Y"))
            {
                Console.Write("생성 할 노드 값(정수) 입력 >> ");
                int intData = Convert.ToInt32(Console.ReadLine());
                // head insert
                tagNode _newnode = new tagNode();
                _newnode = _objLinkedList.SLL_CreateNode(intData);
                SLL_InsertNewHead(_newnode);

                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }
            Chapter01_section01_Progress();
        }

        public void SLL_InsertNewHead(tagNode newNode)
        {
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.NextNode = head;
                head = newNode;
            }
        }
        #endregion switch case 2

        #region switch case 3
        // switch case 3
        public void PrintList()
        {
            tagNode _curr = head;

            int intloop = 0;
            while(_curr != null)
            {
                Console.WriteLine("List[" + intloop .ToString() + "] : " + _curr.Data.ToString());
                _curr = _curr.NextNode;
                intloop++;

            }

            if (intloop.Equals(0))
            {
                Console.WriteLine("리스트 없음");
            }

            Console.Write("enter to exit");
            Console.ReadLine();

            Chapter01_section01_Progress();
        }
        #endregion switch case 3

        #region switch case 4
        public void InserNodeAfter()
        {
            Console.Write("생성 할 노드 값(정수) 입력 >> ");
            int intData = Convert.ToInt32(Console.ReadLine());
            tagNode _newnode = new tagNode();
            _newnode = _objLinkedList.SLL_CreateNode(intData);

            Console.Write("Insert 위치 입력 입력 >> ");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            // 해당 인덱스 위치 정보 get
            tagNode _curr = _objLinkedList.SLL_GetNodeAt(head, intIndex);

            if (_curr == null)
            {
                SLL_AppendNode(_newnode);
            }
            else
            {
                SLL_InsesrtAfter(_curr, _newnode);
            }

            Chapter01_section01_Progress();
        }

        // 노드 삽입
        public void SLL_InsesrtAfter(tagNode current, tagNode newNode)
        {
            newNode.NextNode = current.NextNode;
            current.NextNode = newNode;
        }
        #endregion switch case 4

        #region switch case 5
        public void RemoveAllNode()
        {
            int intAllNodeCnt = _objLinkedList.SLL_GetNodeCount(head);
            for(int i = 0; i < intAllNodeCnt; i++)
            {
                head = head.NextNode;
            }
            if(head == null)
            {
                tail = null;
            }

            Console.WriteLine("모든 노드 제거됨");
            Console.Write("enter to exit");
            Console.ReadLine();

            Chapter01_section01_Progress();
        }

        // 노드 제거
        public void SLL_RemoveNode(tagNode _head, tagNode remove)
        {
            if (_head == remove)
            {
                head = remove.NextNode;
            }
            else
            {
                tagNode _curr = head;
                while(_curr != null && _curr.NextNode != remove)
                {
                    _curr = _curr.NextNode;
                }

                if(_curr != null)
                {
                    _curr.NextNode = remove.NextNode;
                }
            }
        }
        #endregion switch case 6
    }
}
