using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter01
{
    public class Chapter01_Index
    {
        public Chapter01_Index() { }

        public void Chapter01_Progress()
        {
            string strIndex = chapter01Index();
            setChapter01_Section(strIndex);
        }

        public string chapter01Index()
        {
            Console.Clear();

            Console.WriteLine("[ CHAPTER 01 ]");
            Console.WriteLine("1. 링크드 리스트");
            Console.WriteLine("2. 더블 링크드 리스트");
            Console.WriteLine("3. 환형 링크드 리스트");
            Console.WriteLine("4. 뒤로");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();

            return strIndex;
        }

        public void setChapter01_Section(string strIndex)
        {
            switch(strIndex)
            {
                case "1" :
                    Sections.Chapter01_section01 _section01 = new Sections.Chapter01_section01();
                    _section01.Chapter01_section01_Progress();
                    break;
                case "2" :
                    Sections.section02.Chapter01_section02 _section02 = new Sections.section02.Chapter01_section02();
                    _section02.Chapter01_section02_Progress();
                    break;
                case "3" :
                    Sections.section03.Chapter01_section03 _section03 = new Sections.section03.Chapter01_section03();
                    _section03.Chapter01_section03_Progress();
                    break;
                case "4" :
                    Program.mainProgress();
                    break;
                default :
                    break;
            }
        }
    }
}
