using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter05.Sort.Sections.section_03
{
    class InsertSort
    {
        public void InsertSortProgress()
        {
            int[] arrData = new int[] {8, 4, 29, 39, 0 ,1 ,8 ,2 ,1, -3};
            arrData = InsertSorting(arrData, arrData.Length);

            for (int k = 0; k<arrData.Length; k++)
            {
                Console.Write(arrData[k]);
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

        private int[] InsertSorting(int[] arrDataSet, int intLength)
        {
            int i = 0;
            int j = 0;
            int intValue = 0;

            for(i = 1; i < intLength; i++)
            {
                if(arrDataSet[i-1] <= arrDataSet[i])
                {
                    continue;
                }

                intValue = arrDataSet[i];
                for(j = 0; j<i; j++)
                {
                    if(arrDataSet[j] > intValue)
                    {
                        // copy for memory move 
                        Buffer.BlockCopy(arrDataSet, j*sizeof(int), arrDataSet, (j+1)*sizeof(int), (i-j)*sizeof(int));
                        arrDataSet[j] = intValue;
                        break;
                    }
                }
            }
            return arrDataSet;
        }
    }
}
