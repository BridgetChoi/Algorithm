using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter06.Search
{
    class BinarySearch
    {
        private class Score
        {
            public int intNumber;
            public double dblScore;
        }

        public void BinarySearchProgress()
        {
            Score[] arrDataSet = SetScoreData();
            Console.WriteLine("109 번째 값 찾기 >> " + arrDataSet[109].dblScore.ToString());
            Score objResult = FindValueBinarySearch(arrDataSet, arrDataSet.Length, arrDataSet[109].dblScore);

            if (objResult != null)
            {
                Console.WriteLine("발견 된 위치 > " + objResult.intNumber.ToString() + " & 발견 된 값 > " + objResult.dblScore.ToString());
            }
            else
            {
                Console.WriteLine("발견 된 값이 없습니다.");
            }

            string strKeep = "N";
            Console.WriteLine();
            while (!string.IsNullOrEmpty(strKeep))
            {
                Console.Write("Press Enter to return..");
                strKeep = Console.ReadLine();
            }
        }

        private Score[] SetScoreData()
        {
            Score[] arrScoreData = new Score[1000];
            Random objRandom     = new Random();
            double dblRandom     = objRandom.NextDouble() * 200; // rondom double * max

            for (int i = 0; i < 1000; i++)
            {
                arrScoreData[i]  = new Score();
                arrScoreData[i].intNumber = i;
                arrScoreData[i].dblScore  = Math.Round(dblRandom + i, 2);
            }

            return arrScoreData;
        }

        private Score FindValueBinarySearch(Score[] arrDataSet, int intSize, double dblTarget)
        {
            int intLeft  = 0;
            int intRight = intSize - 1;
            int intMid   = 0;

            while(intLeft <= intRight)
            {
                double dblQuotient = (intLeft + intRight) / 2;
                intMid  = Convert.ToInt16(Math.Ceiling(dblQuotient));

                if(dblTarget == arrDataSet[intMid].dblScore)
                {
                    return arrDataSet[intMid];
                }
                else if(dblTarget > arrDataSet[intMid].dblScore)
                {
                    intLeft = intMid + 1;
                }
                else
                {
                    intRight = intMid - 1;
                }
            }

            return null;
        }
    }
}
