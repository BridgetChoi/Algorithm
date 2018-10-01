using System;

namespace Algorithm.Chapter03
{
    class Chapter03_Index
    {
        public Chapter03_Index() {}

        public void Chapter03_Progress()
        {
            string strIndex = Chapter03Index();
            setChapter03_Section(strIndex);
        }

        public string Chapter03Index()
        {
            Console.Clear();

            Console.WriteLine("[ CHAPTER 03 ]");
            Console.WriteLine("1. 순환 큐 ");
            Console.WriteLine("2. 링크드 큐");
            Console.WriteLine("뒤로");
            Console.WriteLine("종료");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();
            return strIndex;
        }

        public void setChapter03_Section(string strIndex)
        {
            switch(strIndex)
            {
                case "1" :
                    Sections.section03.Chapter03_section03 _section03 = new Sections.section03.Chapter03_section03();
                    _section03.Chapter03_section03_Progress();
                    break;
                case "2":
                    Sections.section03.Chapter03_section04 _section04 = new Sections.section03.Chapter03_section04();
                    _section04.Chapter03_section04_Progress();
                    break;
                case "9" :
                    Program.mainProgress();
                    break;
                case "10" :
                    Environment.Exit(0);
                    break;
                default :
                    break;
            }
        }
    }
}
