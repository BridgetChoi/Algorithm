using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithm.Chapter02.Sections.section05
{
    public class Chapter02_section05
    {
        // 전체 후위 표기식을 담을 노드
        private class postfixTagNode
        {
            public string strData;
            public postfixTagNode NextNode = null;
            public postfixTagNode PrevNode = null;
        }
        // 후위 표기식 표현시 함께 사용될 노드
        private class symbolTagNode
        {
            public string strData;
            public symbolTagNode NextNode = null;
            public symbolTagNode PrevNode = null;
        }

        private postfixTagNode HeadPostFix = null;
        private postfixTagNode TailPostFix = null;

        private symbolTagNode HeadSymbol = null;
        private symbolTagNode TailSymbol = null;

        private string LEFT_PARENTHESIS  = "(";
        private string RIGHT_PARENTHESIS = ")";
        private string PLUS              = "+";
        private string MINUS             = "-";
        private string MULTIPLY          = "*";
        private string DIVIDE            = "/";

        private char[] arrExpressionSplit = null;

        public Chapter02_section05() { }

        public void Chapter02_section05_Progress()
        {
            chapter02Selction05Index();
        }

        public void chapter02Selction05Index()
        {
            Console.Clear();
            Console.WriteLine("[ CHAPTER 02 > SELCTION 05 ]");

            Console.Write("사칙 연산 식 입력 >> ");

            string strExpression = Console.ReadLine();
            strExpression = Regex.Replace(strExpression, @"\s+", "");
            // character 단위로 한글자씩 쪼갬
            arrExpressionSplit = strExpression.ToCharArray();

            //for(int i = 0; i < 5; i++)
            //{
            //    pushPostFix(CreatePostFixNode(i.ToString()));
            //    pushSymbolNode(CreateSymbolNode(i.ToString()));
            //}

            //Console.WriteLine("[PostFixNode]");
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(PopPostFixNode());
            //}

            //Console.WriteLine("[SymbolNode]");
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(PopSymbolNode());
            //}
            //Console.Write("enter to exit");
            //Console.ReadLine();
        }

        #region Create Post Fix Expresison
        #endregion Create Post Fix Expresison

        #region Create New Node
        private postfixTagNode CreatePostFixNode(string strData)
        {
            postfixTagNode _newnode = new postfixTagNode();
            _newnode.strData  = strData;
            _newnode.NextNode = null;
            _newnode.PrevNode = null;

            return _newnode;
        }

        private symbolTagNode CreateSymbolNode(string strData)
        {
            symbolTagNode _newnode = new symbolTagNode();
            _newnode.strData  = strData;
            _newnode.NextNode = null;
            _newnode.PrevNode = null;

            return _newnode;
        }
        #endregion Create New Node

        #region Push Node
        private void pushPostFix(postfixTagNode newnode)
        {
            if(HeadPostFix == null)
            {
                HeadPostFix = newnode;
            }
            else
            {
                if (TailPostFix == null)
                {
                    newnode.PrevNode     = HeadPostFix;
                    TailPostFix          = newnode;
                    HeadPostFix.NextNode = TailPostFix;
                }
                else
                {
                    newnode.PrevNode     = TailPostFix;
                    TailPostFix.NextNode = newnode;
                    TailPostFix          = newnode;
                }
            }
        }

        private void pushSymbolNode(symbolTagNode newnode)
        {
            if (HeadSymbol == null)
            {
                HeadSymbol = newnode;
            }
            else
            {
                if (TailSymbol == null)
                {
                    newnode.PrevNode    = HeadSymbol;
                    TailSymbol          = newnode;
                    HeadSymbol.NextNode = TailSymbol;
                }
                else
                {
                    newnode.PrevNode    = TailSymbol;
                    TailSymbol.NextNode = newnode;
                    TailSymbol          = newnode;
                }
            }
        }
        #endregion Push Node

        #region Pop Node
        private string PopPostFixNode()
        {
            string strReturn = string.Empty;

            if(TailPostFix != null)
            {
                postfixTagNode _currTail = TailPostFix;
                strReturn                = _currTail.strData;

                // 테일이 헤드와 동일한 경우
                if (_currTail.PrevNode == null)
                {
                    TailPostFix = null;
                    HeadPostFix = null;
                }
                else
                {
                    _currTail.PrevNode.NextNode = null;
                    TailPostFix                 = _currTail.PrevNode;
                    _currTail.PrevNode          = null;
                    _currTail                   = null;
                }
            }
            else if (HeadPostFix != null)
            {
                strReturn   = HeadPostFix.strData;
                HeadPostFix = null;
            }

            return strReturn;
        }

        private string PopSymbolNode()
        {
            string strReturn = string.Empty;

            if (TailSymbol != null)
            {
                symbolTagNode _currTail = TailSymbol;
                strReturn               = _currTail.strData;

                // 테일이 헤드와 동일한 경우
                if (_currTail.PrevNode == null)
                {
                    TailSymbol = null;
                    HeadSymbol = null;
                }
                else
                {
                    _currTail.PrevNode.NextNode = null;
                    TailSymbol                 = _currTail.PrevNode;
                    _currTail.PrevNode          = null;
                    _currTail                   = null;
                }
            }
            else if (HeadSymbol != null)
            {
                strReturn = HeadSymbol.strData;
                HeadSymbol = null;
            }

            return strReturn;
        }
        #endregion Pop node
    }
}
