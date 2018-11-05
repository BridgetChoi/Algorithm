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
            int[] arrDataSet = new int[] { 6, 4, 2, 3, 1, 5 };
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
                }
            }

            return arrDataSet;
        }
    }
}
