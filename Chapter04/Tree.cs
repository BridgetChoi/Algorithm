using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter04
{
    class Tree
    {
        public Tree() { }
        ~Tree() { }

        public void TreeProgress()
        {
            string strIndex = Chapter04Index();
            setChapter03_Section(strIndex);
        }

        public string Chapter04Index()
        {
            Console.Clear();

            Console.WriteLine("[ CHAPTER 04 ]");
            Console.WriteLine("1. LeftChlidRightSibling 트리 ");
            Console.WriteLine("2. BinaryTree 트리 ");
            Console.WriteLine("뒤로");
            Console.WriteLine("종료");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();
            return strIndex;
        }

        public void setChapter03_Section(string strIndex)
        {
            switch (strIndex)
            {
                case "1":
                    Sections.section01.LeftChildRightSibling _objLeftChildRightSibling = new Sections.section01.LeftChildRightSibling();
                    _objLeftChildRightSibling.LeftChildRightSiblingProgress();
                    Chapter04Index();
                    break;
                case "2":
                    Sections.section02.SimpleBinaryTree _objSimpleBinayTree = new Sections.section02.SimpleBinaryTree();
                    _objSimpleBinayTree.SimpleBinaryTreeProcess();
                    Chapter04Index();
                    break;
                case "9":
                    Program.mainProgress();
                    break;
                case "10":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
