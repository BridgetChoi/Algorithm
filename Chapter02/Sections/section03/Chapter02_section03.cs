using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter02.Sections.section03
{
    public class Chapter02_section03
    {
        private class tagNode
        {
            public int Data;
        }

        private class tagArrayStack
        {
            public int Capacity;
            public int Top;
            public tagNode[] Nodes;
        }

        private tagArrayStack _arrayStack = null;

        public Chapter02_section03() { }

        public void Chapter02_section03_Progress()
        {
            string strIndex = chapter02Selction03Index();
            setChapter02_Selction03_functions(strIndex);
        }

        public string chapter02Selction03Index()
        {
            Console.Clear();
            Console.WriteLine("[ CHAPTER 02 > SELCTION 03 ]");

            Console.WriteLine("1. Array Stack 초기화");
            Console.WriteLine("2, Push");
            Console.WriteLine("3. Pop");
            Console.WriteLine("4. 뒤로");
            Console.WriteLine("5. 종료");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();

            return strIndex;
        }

        public void setChapter02_Selction03_functions(string strIndex)
        {
            switch (strIndex)
            {
                case "1":
                    CreateStack();
                    break;
                case "2":
                    Push();
                    break;
                case "3":
                    Pop();
                    Chapter02_section03_Progress();
                    break;
                case "4":
                    Chapter02.Chapter02_Index _chapter02Index = new Chapter02_Index();
                    _chapter02Index.Chapter02_Progress();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        #region switch case 1
        private void CreateStack()
        {
            Console.Write("Capacity 입력 >> ");
            int intCapacity = Convert.ToInt32(Console.ReadLine());

            AS_CreateStack(intCapacity);

            Chapter02_section03_Progress();
        }

        private void AS_CreateStack(int intCapacity)
        {
            _arrayStack = new tagArrayStack();

            _arrayStack.Capacity = intCapacity;
            _arrayStack.Top = 0;
            _arrayStack.Nodes = new tagNode[intCapacity];
        }
        #endregion switch case 1

        #region switch case 2
        private void Push()
        {
            string strLoop = "Y";
            while(strLoop.Equals("Y"))
            {
                Console.Write("Push 할 값 입력 >> ");
                int intData = Convert.ToInt32(Console.ReadLine());

                AS_Push(intData);

                Console.Write("계속? Y/N >> ");
                strLoop = Console.ReadLine().Trim();
            }
            Chapter02_section03_Progress();
        }

        private void AS_Push(int intData)
        {
            int Position = _arrayStack.Top;

            if(Position.Equals(_arrayStack.Capacity))
            {
                Console.WriteLine("Stack is Full");
                return;
            }

            _arrayStack.Nodes[Position] = new tagNode();
            _arrayStack.Nodes[Position].Data = intData;
            _arrayStack.Top++;
        }
        #endregion switch case 2

        #region switch case 3
        private void Pop()
        {
            int intTop = _arrayStack.Top;

            if (intTop.Equals(0))
            {
                Console.WriteLine("Stack is Empty");
                Console.Write("enter to exit");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < intTop; i++)
                {
                    int intData = AS_Pop();
                    Console.WriteLine("ArrayStack[" + _arrayStack.Top + "] : " + intData.ToString());
                }
                Console.Write("enter to exit");
                Console.ReadLine();
            }
        }

        private int AS_Pop()
        {
            int Position = --(_arrayStack.Top);

            return _arrayStack.Nodes[Position].Data;
        }
        #endregion switch case 3

        private int AS_GetSize()
        {
            return _arrayStack.Top;
        }

    }
}
