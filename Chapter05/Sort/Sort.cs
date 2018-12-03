using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter05.Sort
{
    class Sort
    {
        public Sort() { }
        ~Sort() { }

        public void SortProgress()
        {
            string strIndex = SortIndex();
            setSort_Section(strIndex);
        }

        private string SortIndex()
        {
            Console.Clear();

            Console.WriteLine("[ CHAPTER 05 ]");
            Console.WriteLine("1. Bubble Sort ");
            Console.WriteLine("2. Insert Sort (삽입정렬) ");
            Console.WriteLine("3. 수식 트리 ");
            Console.WriteLine("4. 분리 집합 ");
            Console.WriteLine("5. 뒤로");
            Console.WriteLine("6. 종료");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();
            return strIndex;
        }

        private void setSort_Section(string strIndex)
        {
            switch (strIndex)
            {
                case "1":
                    Sections.section01.BubbleSort _objBubbleSort = new Sections.section01.BubbleSort();
                    _objBubbleSort.BubbleSortProgress();
                    SortIndex();
                    break;
                case "2":
                    Sections.section_03.InsertSort _objInsertSort = new Sections.section_03.InsertSort();
                    _objInsertSort.InsertSortProgress();
                    SortIndex();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    Program.mainProgress();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
