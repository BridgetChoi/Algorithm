using System;

namespace Algorithm.Chapter03.Sections.section03
{
    class Chapter03_section03
    {
        private class tagNode
        {
            public int Data;

            ~tagNode() { }
        }

        private class tagCircularQueue
        {
            public int capacity;          // 용량
            public int Front;              // 전단 인덱스
            public int Rear;               // 후단 
            public tagNode[] Nodes; // 노드 배열

            ~tagCircularQueue() { }
        }

        private tagCircularQueue _tagCircularQueue = null;

        public Chapter03_section03() { }
        ~Chapter03_section03() { }

        public void Chapter03_section03_Progress()
        {
            string strIndex = chapter03Section03Index();
            Chapter03_sections03_function(strIndex);
        }

        public string chapter03Section03Index()
        {
            Console.Clear();
            Console.WriteLine("[ CHAPTER 03 > SELCTION 03 ]");

            Console.WriteLine("1. 순환 큐 초기화");
            Console.WriteLine("2, Enqueue");
            Console.WriteLine("3. Dequeue");
            Console.WriteLine("4. Print Queue");
            Console.WriteLine("5. 뒤로");
            Console.WriteLine("6. 종료");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();

            return strIndex;
        }

        public void Chapter03_sections03_function(string strIndex)
        {
            switch(strIndex)
            {
                case "1":
                    createQueue();
                    break;
                case "2":
                    Enqueue();
                    break;
                case "3":
                    CQ_Dequeue();
                    break;
                case "4":
                    CQ_Print();
                    break;
                case "5":
                    Chapter03.Chapter03_Index _chapter03Index = new Chapter03_Index();
                    _chapter03Index.Chapter03_Progress();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default :
                    break;
            }
        }

        #region switch case 1
        public void createQueue()
        {
            Console.Write("Capacity 입력 >> ");
            int intCapacity = Convert.ToInt32(Console.ReadLine());

            CQ_CreateQueue(intCapacity);
            Chapter03_section03_Progress();
        }

        public void CQ_CreateQueue(int intCapacity)
        {
            _tagCircularQueue = new tagCircularQueue();
            _tagCircularQueue.capacity = intCapacity; // 실제 큐 수용량
            _tagCircularQueue.Front = 0;                   // 처음 배열의 인덱스
            _tagCircularQueue.Rear = 0;                    // 후단 배열의 인덱스
            _tagCircularQueue.Nodes = new tagNode[intCapacity + 1]; // Dummy Node 를 +1
        }
        #endregion switch case 1
        #region switch case 2
        public void Enqueue()
        {
            string strLoop = "Y";
            while(strLoop.Equals("Y"))
            {
                Console.Write("Enqueue 값 입력 >> ");
                int intData = Convert.ToInt32(Console.ReadLine());
                CQ_Enqueue(intData);

                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }
            Chapter03_section03_Progress();
        }

        public void CQ_Enqueue(int intData)
        {
            if(CQ_isFull())
            {
                Console.WriteLine("Queue is full.");
                return;
            }
            else
            {
                int intPosition = 0;
                intPosition = _tagCircularQueue.Rear;
                if (_tagCircularQueue.Rear == _tagCircularQueue.capacity)
                {
                    _tagCircularQueue.Rear = 0;
                }
                else
                {
                    _tagCircularQueue.Rear = _tagCircularQueue.Rear + 1;
                }
                _tagCircularQueue.Nodes[intPosition] = new tagNode();
                _tagCircularQueue.Nodes[intPosition].Data = intData;
             }
        }

        public bool CQ_isFull()
        {
            // 전단 보다 후단의 인덱스가 큰 경우 if : 전단 - 후단 == capacity then : full
            if(_tagCircularQueue.Front < _tagCircularQueue.Rear)
            {
                if((_tagCircularQueue.Rear - _tagCircularQueue.Front) == _tagCircularQueue.capacity)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // 후단보다 전단의 인덱스가 큰 경우 if : 후단 + 1 == 전단 then : full
            else
            {
                if((_tagCircularQueue.Rear + 1) == _tagCircularQueue.Front)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion switch case 2
        #region switch case 3
        public void CQ_Dequeue()
        {
            if (CQ_isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                string strLoop = "Y";
                while(strLoop.Equals("Y"))
                {
                    Console.Write("Dequeue Y/N >> ");
                    string strDequeueYN = Console.ReadLine();

                    if(strDequeueYN.Equals("Y"))
                    {
                        Dequeue();
                        Console.Write("계속 Y/N ? >> ");
                        strLoop = Console.ReadLine();
                    }
                }
                Chapter03_section03_Progress();
            }

        }

        public bool CQ_isEmpty()
        {
            if(_tagCircularQueue.Front == _tagCircularQueue.Rear)
            {
                return true;
            }
            return false;
        }

        public void Dequeue()
        {
            int intPostion = _tagCircularQueue.Front;
            if (_tagCircularQueue.Front == _tagCircularQueue.capacity)
            {
                _tagCircularQueue.Front = 0;
            }
            else
            {
                _tagCircularQueue.Front = _tagCircularQueue.Front + 1;
            }

            _tagCircularQueue.Nodes[intPostion] = new tagNode();
            Console.WriteLine(intPostion.ToString() + " position is dequeued.");
        }
        #endregion switch case 3
        #region switch case 4
        public void CQ_Print()
        {
            if(CQ_isEmpty())
            {
                Console.WriteLine("Circular queue is empty.");
            } 
            else
            {
                for(int i = 0; i < _tagCircularQueue.Nodes.Length; i ++)
                {
                    if (i == _tagCircularQueue.Rear)
                    {
                        Console.Write(" | - ");
                    }
                    else
                    {
                        Console.Write(" | " + _tagCircularQueue.Nodes[i].Data.ToString());
                    }
                }

                string strReturn = "N";
                while (strReturn.Equals("N"))
                {
                    Console.Write(" Return to Index Y/N>> ");
                    strReturn = Console.ReadLine();
                    if (strReturn.Equals("Y"))
                    {
                        Chapter03_section03_Progress();
                    }
                 }
            }
        }
        #endregion switch case 4
    }
}
