using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter04.Sections.section04
{
    class DisJointSet
    {
        private class tagDisJointSet
        {
            public tagDisJointSet objParent;
            public int intData;
        }

        public void DisJointSetProcess()
        {
            tagDisJointSet objSet1 = DS_MakeSet(1);
            tagDisJointSet objSet2 = DS_MakeSet(2);
            tagDisJointSet objSet3 = DS_MakeSet(3);
            tagDisJointSet objSet4 = DS_MakeSet(4);

            tagDisJointSet objTemp = DS_FindSet(objSet1);
            if(objTemp == objSet1)
            {
                Console.WriteLine("Set1 doesn't have union.");
            }

            objTemp = DS_FindSet(objSet2);
            if (objTemp == objSet2)
            {
                Console.WriteLine("Set2 doesn't have union.");
            }

            DS_UnionSet(objSet1, objSet3);
            objTemp = DS_FindSet(objSet1);
            if (objTemp == objSet1)
            {
                Console.WriteLine("Set1 doesn't have union.");
            }
            objTemp = DS_FindSet(objSet3);
            if(objTemp == objSet1)
            {
                Console.WriteLine("Set3 is included in Set1.");
            }

            DS_UnionSet(objSet2, objSet4);
            objTemp = DS_FindSet(objSet2);
            if(objTemp == objSet2)
            {
                Console.WriteLine("Set2 doesn't have union.");
            }
            objTemp = DS_FindSet(objSet4);
            if (objTemp == objSet2)
            {
                Console.WriteLine("Set4 is included in Set2.");
            }

            string strKeep = "N";
            Console.WriteLine();
            while (!string.IsNullOrEmpty(strKeep))
            {
                Console.Write("Press Enter to return..");
                strKeep = Console.ReadLine();
            }
        }

        private void DS_UnionSet(tagDisJointSet objSet1, tagDisJointSet objSet2)
        {
            objSet2 = DS_FindSet(objSet2);
            objSet2.objParent = objSet1;
        }

        private tagDisJointSet DS_FindSet(tagDisJointSet objSet)
        {
            while(objSet.objParent != null)
            {
                objSet = objSet.objParent;
            }

            return objSet;
        }

        private tagDisJointSet DS_MakeSet(int intNewData)
        {
            tagDisJointSet objNewData = new tagDisJointSet();
            objNewData.intData   = intNewData;
            objNewData.objParent = null;

            return objNewData;
        }
    }
}
