using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter06.Search
{
    class Search
    {
        public void SearchProcess()
        {
            string strIndex = SearchIndex();
            setSearchSection(strIndex);
        }

        private string SearchIndex()
        {
            Console.Clear();

            Console.WriteLine("[ CHAPTER 06 ]");
            Console.WriteLine("1. 순차탐색 ");
            Console.WriteLine("2. Binary Search ");
            Console.WriteLine("3. Binary Search Tree ");
            Console.WriteLine("4. Insert Sort with Double LinkedList ");
            Console.WriteLine("5. 뒤로");
            Console.WriteLine("6. 종료");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();
            return strIndex;
        }

        private void setSearchSection(string strIndex)
        {
            switch (strIndex)
            {
                case "1":
                    Chapter06.Search.SequentialSearch objSequentialSearch = new Chapter06.Search.SequentialSearch();
                    objSequentialSearch.SequentialSearchProgress();
                    SearchIndex();
                    break;
                case "2":
                    Chapter06.Search.BinarySearch objBinarySearch = new Chapter06.Search.BinarySearch();
                    objBinarySearch.BinarySearchProgress();
                    SearchIndex();
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
