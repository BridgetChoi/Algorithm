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

        // 1. 포인터 노트 클래스
        public class tagNode
        {
            public int Data;
            public tagNode NextNode;
        }

        // 2. 노드 생성
        public tagNode SLL_CreateNode(int newData)
        {
            tagNode _newNode = new tagNode();
            _newNode.Data     = newData; // 데이터 저장
            _newNode.NextNode = null;    // 다음 노드에 대한 포인터는 null

            return _newNode;
        }

        // 3. 노드 소멸
        public void SLL_DestroyNode(tagNode node)
        {
            node = null;
        }

        // 4. 노드 추가
        public void SLL_AppendNode(tagNode head, tagNode tail, tagNode current, tagNode newNode)
        {
            // head 노드가 null 이면 새로운 노드가 head & tail
            if(head == null)
            {
                head    = newNode;
                current = newNode;
                tail    = newNode;
            }
            else
            {
                tagNode curTail = new tagNode();
                curTail = tail;
                curTail.NextNode = newNode; // 현재 tail의 next node 가 newnode
                tail = newNode;             // newnode 가 새로운 tail 이 됨
            }
        }

        // 5. 노드 삽입
        public void SLL_InsesrtAfter(tagNode current, tagNode newNode)
        {
            newNode.NextNode = current.NextNode;
            current.NextNode = newNode;
        }

        
    }
}
