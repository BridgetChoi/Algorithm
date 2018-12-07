using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter05.Sort.Sections.section04
{
    class QuickSort
    {
        public void QuickSortProgress()
        {
            int[] intDataSet = {6,4,2,3,1,5};
            int intLength = intDataSet.Length;
            int i = 0;

            SetQuickSort(ref intDataSet, 0, intLength-1);

            for(i = 0; i < intLength; i++)
            {
                Console.Write(intDataSet[i]);
                Console.Write("     ");
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

        private void Swap(ref int intA, ref int intB)
        {
            int intTemp = intA;
            intA = intB;
            intB = intTemp;
        }

        private int Partition(ref int[] arrDataSet, int intLeft, int intRight)
        {
            int intFirst = intLeft;
            int intPivot = arrDataSet[intFirst];

            ++intLeft;

            while(intLeft <= intRight)
            {
                // find big value more than pivot on the left side
                while(arrDataSet[intLeft] <= intPivot && intLeft < intRight)
                {
                    ++intLeft;
                }
                // find small value more than pivot on the right side
                while(arrDataSet[intRight] > intPivot && intLeft <= intRight)
                {
                    --intRight;
                }

                if(intLeft < intRight)
                {
                    Swap(ref arrDataSet[intLeft], ref arrDataSet[intRight]);
                }
                else
                {
                    break;
                }
            }

            Swap(ref arrDataSet[intFirst], ref arrDataSet[intRight]);
            return intRight;
        }
        
        private void SetQuickSort(ref int[] arrDataSet, int intLeft, int intRight)
        {
            if(intLeft < intRight)
            {
                int intIndex = Partition(ref arrDataSet, intLeft, intRight);

                SetQuickSort(ref arrDataSet, intLeft, intIndex-1);
                SetQuickSort(ref arrDataSet, intIndex + 1, intRight);
            }
        }
    }
}
