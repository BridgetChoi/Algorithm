using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                mainProgress();
            }
        }

        public static void mainProgress()
        {
            string strIndex = bookIndex();
            setChapter(strIndex);
        }

        public static string bookIndex()
        {
            Console.Clear();

            Console.WriteLine("1. 리스트");
            Console.WriteLine("2. 스택");
            Console.WriteLine("3. 큐");
            Console.WriteLine("4. 트리");
            Console.WriteLine("5. 정렬");

            Console.WriteLine("6. 탐색");
            Console.WriteLine("7. 우선순위 큐와 힙");
            Console.WriteLine("8. 해시 테이블");
            Console.WriteLine("9. 그래프");
            Console.WriteLine("10. 문자열 검색");

            Console.WriteLine("11. 알고리즘 성능 분석");
            Console.WriteLine("12. 분할 정복");
            Console.WriteLine("13. 동적 계획법");
            Console.WriteLine("14. 탐욕 알고리즘");
            Console.WriteLine("15. 백트랙킹");
            Console.WriteLine("16. 종료");
            Console.WriteLine("--------------------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();

            return strIndex.Trim();
        }

        public static void setChapter(string strIndex)
        {
            switch(strIndex)
            {
                case "1" :
                    Algorithm.Chapter01.Chapter01_Index _objChapter01 = new Chapter01.Chapter01_Index();
                    _objChapter01.Chapter01_Progress();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
                case "10":
                    break;
                case "11":
                    break;
                case "12":
                    break;
                case "13":
                    break;
                case "14":
                    break;
                case "15":
                    break;
                case "16" :
                    Environment.Exit(0);
                    break;
                default :
                    break;
            }
        }
    }
}
