using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter01.Sections
{
    public class Chapter01_section01
    {
        int intCount = 0;

        section01.LinkedList.tagNode head    = null;
        section01.LinkedList.tagNode Current = null;
        section01.LinkedList.tagNode tail    = null;

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
            Console.WriteLine("2, 노드 소멸");
            Console.WriteLine("3. 노드 추가");
            Console.WriteLine("4. 노드 삽입");
            Console.WriteLine("5. 노드 제거");

            Console.WriteLine("6. 노드 탐색");
            Console.WriteLine("7. 노드 수 세기");
            Console.WriteLine("8. 뒤로");
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
                    break;
                case "2" :
                    break;
                case "3" :
                    break;
                case "4" :
                    break;
                case "5" :
                    break;
                case "6" :
                    break;
                case "7" :
                    break;
                case "8" :
                    Chapter01.Chapter01_Index _chapter01Index = new Chapter01_Index();
                    _chapter01Index.Chapter01_Progress();
                    break;
                default :
                    break;
            }
        }
    }
}
