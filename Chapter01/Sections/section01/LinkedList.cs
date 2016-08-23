using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter01.Sections.section01
{
    public class LinkedList
    {
        public LinkedList() { }

        // 2. 노드 생성
        public Sections.Chapter01_section01.tagNode SLL_CreateNode(int newData)
        {
            Sections.Chapter01_section01.tagNode _newNode = new Sections.Chapter01_section01.tagNode();
            _newNode.Data     = newData; // 데이터 저장
            _newNode.NextNode = null;    // 다음 노드에 대한 포인터는 null

            return _newNode;
        }

        // 3. 노드 소멸
        public void SLL_DestroyNode(Sections.Chapter01_section01.tagNode node)
        {
            node = null;
        }

        // 5. 노드 탐색
        public Sections.Chapter01_section01.tagNode SLL_GetNodeAt(Sections.Chapter01_section01.tagNode head, int intLocation)
        {
            Sections.Chapter01_section01.tagNode current = head;

            if(intLocation.Equals(0))
            {
                return head;
            }
            else
            {
                for(int i = 0; i < intLocation; i++)
                {
                    current = current.NextNode;
                }
            }

            //while(current != null && (intLocation--) >= 1)
            //{
            //    current = current.NextNode;
            //}

            return current;
        }

        // 6. 노드 수 세기
        public int SLL_GetNodeCount(Sections.Chapter01_section01.tagNode head)
        {
            int intCount = 0;
            Sections.Chapter01_section01.tagNode current = head;

            while (current != null)
            {
                current = current.NextNode;
                intCount++;
            }

            return intCount;
        }
    }
}
