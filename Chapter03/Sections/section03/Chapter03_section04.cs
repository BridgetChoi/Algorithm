using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter03.Sections.section03
{
    class Chapter03_section04
    {
        private class tagNode
        {
            public int Data;
            public tagNode NextNode; 

            ~tagNode() { }
        }

        private class tagLinkedQueue
        {
            public tagNode Front;
            public tagNode Rear;
            public int Count;

            ~tagLinkedQueue() { };
        }

        private tagLinkedQueue _tagLinkedQueue = null;

        public void Chapter03_section04_Progress()
        {
            string strIndex = chapter03Section04Index();
            Chapter03_sections04_function(strIndex);
        }

        public string chapter03Section04Index()
        {
            Console.Clear();
            Console.WriteLine("[ CHAPTER 03 > SELCTION 04 ]");

            Console.WriteLine("1. 링크드 큐 초기화");
            Console.WriteLine("2, Enqueue");
            Console.WriteLine("3. Dequeue");
            Console.WriteLine("4. 뒤로");
            Console.WriteLine("5. 종료");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();

            return strIndex;
        }

        public void Chapter03_sections04_function(string strIndex)
        {
            switch(strIndex)
            {
                case "1":
                    LQ_CreateQueue();
                    break;
                case "2":
                    LQ_Enqueue();
                    break;
                case "3":
                    LQ_Dequeue();
                    break;
                case "4":
                    Chapter03.Chapter03_Index _chapter03Index = new Chapter03_Index();
                    _chapter03Index.Chapter03_Progress();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        #region Create Linked Queue
        public void LQ_CreateQueue()
        {
            // 큐 시작 노드 초기화
            if(_tagLinkedQueue == null)
            {
                _tagLinkedQueue = new tagLinkedQueue();
                _tagLinkedQueue.Front  = null;
                _tagLinkedQueue.Rear   = null;
                _tagLinkedQueue.Count = 0;
            }
            Chapter03_section04_Progress();
        }
        #endregion Create Linked Queue

        #region Create New Node & Enqueue
        private tagNode LQ_CreateNode(int data)
        {
            tagNode _newNode  = new tagNode();
            _newNode.Data        = data;
            _newNode.NextNode = null;

            return _newNode;
        }

        public void LQ_Enqueue()
        {
            string strLoop = "Y";
            while (strLoop.Equals("Y"))
            {
                Console.Write("Enqueue 값 입력 >> ");
                int intData = Convert.ToInt32(Console.ReadLine());
                tagNode _new = this.LQ_CreateNode(intData);

                if(_tagLinkedQueue.Front == null)
                {
                    _tagLinkedQueue.Front = _new;
                    _tagLinkedQueue.Rear  = _new;
                    _tagLinkedQueue.Count++;
                }
                else
                {
                    _tagLinkedQueue.Rear.NextNode = _new;
                    _tagLinkedQueue.Rear               = _new;
                    _tagLinkedQueue.Count++;
                }

                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }
            Chapter03_section04_Progress();
        }
        #endregion Create New Node & Enqueue

        #region Dequeue
        public void LQ_Dequeue()
        {
            string strLoop = "Y";
            while (strLoop.Equals("Y"))
            {
                tagNode _front = _tagLinkedQueue.Front;
                if (_front == null)
                {
                    Console.WriteLine("Linked Queue is empty.");
                }
                else
                {
                    if (_tagLinkedQueue.Front.NextNode == null)
                    {
                        _tagLinkedQueue.Front = null;
                        _tagLinkedQueue.Rear = null;
                    }
                    else
                    {
                        _tagLinkedQueue.Front = _tagLinkedQueue.Front.NextNode;
                    }

                    _tagLinkedQueue.Count--;

                    Console.WriteLine("Dequeue value is " + _front.Data.ToString());
                    _front = null;
                }
                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }
            Chapter03_section04_Progress();
        }
        #endregion Dequeue
    }
}
