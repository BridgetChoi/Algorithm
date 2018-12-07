using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter05.Sort.Sections.section01
{
    class BubbleSort
    {
        public void BubbleSortProgress()
        {
            int[] arrDataSet = new int[] { 1,2,3,4,5,6 };
            int intLength = arrDataSet.Length;
            int[] arrResult = BubbleSorting(arrDataSet, intLength);

            for(int i = 0; i < arrResult.Length; i++)
            {
                Console.Write(arrResult[i]);
                Console.Write(" ");

            }
            Console.WriteLine();

            string strKeep = "N";
            Console.WriteLine();
            while (!string.IsNullOrEmpty(strKeep))
            {
                Console.Write("Press Enter to return..");
                strKeep = Console.ReadLine();
            }
        }

        private int[] BubbleSorting(int[] arrDataSet, int intLength)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            int intBreakCnt = 0;

            for(i = 0; i < intLength-1; i++)
            {
                for(j = 0; j < intLength - (i+1); j++)
                {
                    if(arrDataSet[j] > arrDataSet[j+1])
                    {
                        temp              = arrDataSet[j + 1];
                        arrDataSet[j + 1] = arrDataSet[j];
                        arrDataSet[j]     = temp;
                    }
                    else if(i == 0 && arrDataSet[j] <= arrDataSet[j+1])
                    {
                        intBreakCnt++;
                    }
                }

                if(i == 0 && intBreakCnt == intLength-(i+1))
                {
                    Console.WriteLine("Do not neet to be sorted.");
                    break;
                }
            }

            return arrDataSet;
        }
    }
}
