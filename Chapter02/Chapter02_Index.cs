﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter02
{
    public class Chapter02_Index
    {
        public Chapter02_Index() { }

        public void Chapter02_Progress()
        {
            string strIndex = chapter02Index();
            setChapter01_Section(strIndex);
        }

        public string chapter02Index()
        {
            Console.Clear();

            Console.WriteLine("[ CHAPTER 02 ]");
            Console.WriteLine("1. 배열 스택");
            Console.WriteLine("2. Linked List 스택");
            Console.WriteLine("3. 사칙 연산 계산 : 후위 표기식");
            Console.WriteLine("4. 뒤로");
            Console.WriteLine("5. 종료");
            Console.WriteLine("----------------------------");
            Console.Write("인덱스 입력 >> ");

            string strIndex = Console.ReadLine();

            return strIndex;
        }

        public void setChapter01_Section(string strIndex)
        {
            switch (strIndex)
            {
                case "1" :
                    Sections.section03.Chapter02_section03 _section03 = new Sections.section03.Chapter02_section03();
                    _section03.Chapter02_section03_Progress();
                    break;
                case "2" :
                    Sections.section04.Chapter02_section04 _section04 = new Sections.section04.Chapter02_section04();
                    _section04.Chapter02_section04_Progress();
                    break;
                case "3" :
                    Sections.section05.Chapter02_section05 _section05 = new Sections.section05.Chapter02_section05();
                    _section05.Chapter02_section05_Progress();
                    break;
                case "4" :
                    Program.mainProgress();
                    break;
                case "5" :
                    Environment.Exit(0);
                    break;
                default :
                    break;
            }
        }
    }
}
