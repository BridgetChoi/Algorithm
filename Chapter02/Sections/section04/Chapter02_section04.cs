using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter02.Sections.section04
{
    public class Chapter02_section04
    {
        private class tagNode
        {
            public string Data;
            public tagNode PrevNode;
            public tagNode NextNode;
        }

        private class tagLinkedListStack
        {
            public tagNode Head = null;
            public tagNode Tail = null;
        }

        private tagLinkedListStack _LinkedListStack = new tagLinkedListStack();

        public Chapter02_section04() { }

        public void Chapter02_section04_Progress()
        {
            string strIndex = chapter02Selction04Index();
            setChapter02_Selction04_functions(strIndex);
        }

        public string chapter02Selction04Index()
        {
            Console.Clear();
            Console.WriteLine("[ CHAPTER 02 > SELCTION 04 ]");

            Console.WriteLine("1. Linked List Stack Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. 뒤로");
            Console.WriteLine("4. 종료");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();

            return strIndex;
        }

        public void setChapter02_Selction04_functions(string strIndex)
        {
            switch (strIndex)
            {
                case "1" :
                    Push();
                    break;
                case "2" :
                    pop();
                    break;
                case "3" :
                    Chapter02.Chapter02_Index _chapter02Index = new Chapter02_Index();
                    _chapter02Index.Chapter02_Progress();
                    break;
                case "4" :
                    Environment.Exit(0);
                    break;
                default :
                    break;
            }
        }

        #region switch case 1
        private void Push()
        {
            string strLoop = "Y";
            while (strLoop.Equals("Y"))
            {
                Console.Write("생성할 Stack 노드 값 입력 >> ");
                string strData = Console.ReadLine();
                
                tagNode _newnode = LLS_CreateNode(strData);
                LLS_Push(_newnode);

                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }
            Chapter02_section04_Progress();
        }

        private tagNode LLS_CreateNode(string strData)
        {
            tagNode _newnode = new tagNode();

            _newnode.Data = strData;
            _newnode.NextNode = null;
            _newnode.PrevNode = null;

            return _newnode;
        }

        private void LLS_Push(tagNode _newnode)
        {
            if(_LinkedListStack.Head == null)
            {
                _LinkedListStack.Head = _newnode;
            }
            else
            {
                tagNode _oldtail = _LinkedListStack.Tail;

                if (_oldtail == null)
                {
                    _LinkedListStack.Tail = _newnode;
                    _LinkedListStack.Tail.PrevNode = _LinkedListStack.Head;
                    _LinkedListStack.Head.NextNode = _LinkedListStack.Tail;
                }
                else
                {
                    _oldtail.NextNode = _newnode;
                    _newnode.PrevNode = _oldtail;
                    _LinkedListStack.Tail = _newnode;
                }
            }
        }
        #endregion switch case 1

        #region switch case 2
        private void pop()
        {
            if(_LinkedListStack.Head == null)
            {
                Console.WriteLine("List is empty.");
                Console.Write("enter to exit");
                Console.ReadLine();
            }
            else
            {
                while(true)
                {
                    tagNode _return = LLS_Pop();
                    if (_return == null) break;

                    Console.WriteLine(_return.Data);
                }
                Console.Write("enter to exit");
                Console.ReadLine();
            }
            Chapter02_section04_Progress();
        }
        private tagNode LLS_Pop()
        {
            tagNode _return = (_LinkedListStack.Tail == null) ? _LinkedListStack.Head : _LinkedListStack.Tail;

            if(_return != null)
            {
                if (_return.PrevNode != null)
                {
                    _return.PrevNode.NextNode = null;
                }
                else
                {
                    _LinkedListStack.Head = null;
                }

                _LinkedListStack.Tail = _return.PrevNode;
            }

            return _return;
        }
        #endregion switch case 2
    }
}
