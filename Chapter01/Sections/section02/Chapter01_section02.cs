using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter01.Sections.section02
{
    public class Chapter01_section02
    {
        public class tagNodeDouble
        {
            public int intData;
            public tagNodeDouble PrevNode;
            public tagNodeDouble NextNode;
        }

        public tagNodeDouble Head = null;
        public tagNodeDouble Tail = null;

        public Chapter01_section02() { }

        public void Chapter01_section02_Progress()
        {
            string strIndex = chapter01Selction02Index();
            setChapter01_Selction02_functions(strIndex);
        }

        public string chapter01Selction02Index()
        {
            Console.Clear();
            Console.WriteLine("[ CHAPTER 01 > SELCTION 02 ]");

            Console.WriteLine("1. 노드 추가");
            Console.WriteLine("2. 리스트 출력");
            Console.WriteLine("3. 노드 삽입");
            Console.WriteLine("4. 모든 노드 제거");
            Console.WriteLine("5. 역순 출력 ");
            Console.WriteLine("6. 뒤로");
            Console.WriteLine("7. 종료");
            Console.WriteLine("---------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();

            return strIndex;
        }

        public void setChapter01_Selction02_functions(string strIndex)
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
                    PrintListReverse();
                    break;
                case "6" :
                    Chapter01.Chapter01_Index _chapter01Index = new Chapter01_Index();
                    _chapter01Index.Chapter01_Progress();
                    break;
                case "7" :
                    Environment.Exit(0);
                    break;
                default :
                    break;
            }
        }

        #region switch case 1
        public void CreateNode()
        {
            string strLoop = "Y";
            while (strLoop.Equals("Y"))
            {
                Console.Write("생성 할 노드 값(정수) 입력 >> ");
                int intData = Convert.ToInt32(Console.ReadLine());

                tagNodeDouble _newnode = new tagNodeDouble();
                _newnode = DLL_CreateNode(intData);
                DLL_AppendNode(_newnode);

                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }

            Chapter01_section02_Progress();
        }
        // 노드 생성
        public tagNodeDouble DLL_CreateNode(int Data)
        {
            tagNodeDouble _newnode = new tagNodeDouble();

            _newnode.intData  = Data;
            _newnode.PrevNode = null;
            _newnode.NextNode = null;

            return _newnode;
        }
        // 노드 추가
        public void DLL_AppendNode(tagNodeDouble newnode)
        {
            if(Head == null)
            {
                Head = newnode;
            }
            else
            {
                // tail 을 찾는다
                tagNodeDouble _tail = Head;
                while(_tail.NextNode != null)
                {
                    _tail = _tail.NextNode;
                }

                _tail.NextNode = newnode;
                newnode.PrevNode = _tail;
            }
        }
        #endregion switch case 1

        #region switch csae 2
        // 리스트 출력
        public void PrintList()
        {
            tagNodeDouble _head = Head;
            int intLoop = 0;
            while(_head != null)
            {
                Console.WriteLine("List[" + intLoop.ToString() + "] : " + _head.intData.ToString());
                _head = _head.NextNode;
                intLoop++;
            }

            if (intLoop.Equals(0))
            {
                Console.WriteLine("리스트 없음");
            }

            Console.Write("enter to exit");
            Console.ReadLine();

            Chapter01_section02_Progress();
        }
        #endregion switch case 2

        #region switch case 3
        public void InsertNode()
        {
            string strLoop = "Y";
            while (strLoop.Equals("Y"))
            {
                Console.Write("삽일 할 노드 값 >> ");
                int intData = Convert.ToInt32(Console.ReadLine());
                // 삽입할 노드 생성
                tagNodeDouble _newnode = new tagNodeDouble();
                _newnode = DLL_CreateNode(intData);

                Console.Write("삽입 할 위치 >> ");
                int intIndex = Convert.ToInt32(Console.ReadLine());

                DLL_InsertAfter(_newnode, intIndex);

                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }

            Chapter01_section02_Progress();
        }
        // 특정 위치에 노드 삽입
        public void DLL_InsertAfter(tagNodeDouble newnode, int Index)
        {
            if(Index.Equals(0))
            {
                newnode.NextNode = Head;
                Head.PrevNode = newnode;
                Head = newnode;
            }
            else
            {
                tagNodeDouble _current = DLL_GetNodeAt(Index);
                // 현존 노드 수 보다 큰 Index 입력된 경우 tail 뒤로 넣는다.
                if(_current == null)
                {
                    DLL_AppendNode(newnode);
                }
                else
                {
                    newnode.NextNode = _current.NextNode;
                    newnode.PrevNode = _current.NextNode.PrevNode;

                    _current.NextNode = newnode;
                    _current.NextNode.PrevNode = newnode;
                }
            }
        }
        // 해당 위치의 노트 return
        public tagNodeDouble DLL_GetNodeAt(int Index)
        {
            tagNodeDouble _curr = Head;
            while(_curr != null && (--Index) > 0)
            {
                _curr = _curr.NextNode;
            }

            return _curr;
        }
        #endregion switch case 3

        #region switch case 4
        public void RemoveNode()
        {
            int intCnt = DLL_GetNodeCount();
            for(int i = 0; i < intCnt; i++)
            {
                tagNodeDouble _head = Head;
                Head = _head.NextNode;
                if (Head != null)
                {
                    Head.PrevNode = null;
                }
                _head.NextNode = null;
                _head.PrevNode = null;
            }

            Chapter01_section02_Progress();
        }
        // 전체 노드 수 return
        public int DLL_GetNodeCount()
        {
            tagNodeDouble _curr = Head;
            int intCnt = 0;
            while(_curr != null)
            {
                _curr = _curr.NextNode;
                intCnt++;
            }

            return intCnt;
        }
        // 노드제거
        public void DLL_RemoveNode(tagNodeDouble remove)
        {
            if(Head == remove)
            {
                Head = remove.NextNode;
                if(Head != null)
                {
                    Head.PrevNode = null;
                }
                remove.NextNode = null;
                remove.PrevNode = null;
            }
            else
            {
                tagNodeDouble _remove = remove;

                if(remove.PrevNode != null)
                {
                    remove.PrevNode.NextNode = _remove.NextNode;
                }

                if (remove.NextNode != null)
                {
                    remove.NextNode.PrevNode = _remove.PrevNode;
                }

                remove.NextNode = null;
                remove.PrevNode = null;
            }
        }
        #endregion switch case 4

        #region switch case 5
        public void PrintListReverse()
        {
            int intCnt = DLL_GetNodeCount();
            tagNodeDouble _curr = DLL_GetNodeAt(intCnt);

            while(_curr != null)
            {
                Console.WriteLine("List[" + intCnt.ToString() + "] : " + _curr.intData.ToString());
                _curr = _curr.PrevNode;
                intCnt--;
            }

            Console.Write("enter to exit");
            Console.ReadLine();

            Chapter01_section02_Progress();
        }
        #endregion switch case 5
    }
}
