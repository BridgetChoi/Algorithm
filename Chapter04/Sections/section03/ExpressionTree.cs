using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Chapter04.Sections.section03
{
    class ExpressionTree
    {
        private class tagETNode
        {
            public tagETNode objLeft;
            public tagETNode objRight;
            public string strData;
        }

        private string[] arrExpression = new string[] { "7", "1", "*", "5", "2", "-", "/" };
        private tagETNode objRoot = null;

        public void ExpresstionTreeProcess()
        {
            this.ET_BuildExpressionTree(ref objRoot);

            Console.WriteLine();
            this.ET_PreorderPrintTree(objRoot);
            Console.WriteLine();
            this.ET_InorderPrintTree(objRoot);
            Console.WriteLine();
            this.ET_PostorderPrintTree(objRoot);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Evaluate result is " + ET_Evaluate(objRoot).ToString());
            ET_DestroyNode(ref objRoot);
            string strKeep = "N";
            Console.WriteLine();
            while (!string.IsNullOrEmpty(strKeep))
            {
                Console.Write("Press Enter to return..");
                strKeep = Console.ReadLine();
            }
        }

        private tagETNode ET_CreateNode(string Data)
        {
            tagETNode objTemp = new tagETNode();
            objTemp.objLeft    = null;
            objTemp.objRight  = null;
            objTemp.strData = Data;

            return objTemp;
        }

        private void ET_DestroyNode(ref tagETNode objNode)
        {
            objNode = null;
        }

        private void ET_PreorderPrintTree(tagETNode objNode)
        {
            if(objNode == null)
            {
                return;
            }

            Console.Write(objNode.strData);
            ET_PreorderPrintTree(objNode.objLeft);
            ET_PreorderPrintTree(objNode.objRight);
        }

        private void ET_InorderPrintTree(tagETNode objNode)
        {
            if(objNode == null)
            {
                return;
            }

            Console.Write("(");
            ET_InorderPrintTree(objNode.objLeft);

            Console.Write(objNode.strData);

            ET_InorderPrintTree(objNode.objRight);
            Console.Write(")");
        }

        private void ET_PostorderPrintTree(tagETNode objNode)
        {
            if(objNode == null)
            {
                return;
            }

            ET_PostorderPrintTree(objNode.objLeft);
            ET_PostorderPrintTree(objNode.objRight);
            Console.Write(objNode.strData);
        }

        private void ET_BuildExpressionTree(ref tagETNode objNode)
        {
            int intLen = arrExpression.Length;
            if(intLen <= 0)
            {
                return;
            }
            string strToken = arrExpression[intLen - 1];
            arrExpression[intLen - 1] = null;
            arrExpression = arrExpression.Take(intLen - 1).ToArray();

            switch(strToken)
            {
                case "+" :
                case "-" :
                case "*" :
                case "/" :
                    objNode = ET_CreateNode(strToken);
                    ET_BuildExpressionTree(ref objNode.objRight);
                    ET_BuildExpressionTree(ref objNode.objLeft);
                    break;
                default :
                    objNode = ET_CreateNode(strToken);
                    break;
            }
        }

        private double ET_Evaluate(tagETNode objNode)
        {
            string strCalculator = null;

            double Left = 0;
            double Right = 0;
            double Result = 0;

            if(objNode == null)
            {
                return 0;
            }

            switch(objNode.strData)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    Left = ET_Evaluate(objNode.objLeft);
                    Right = ET_Evaluate(objNode.objRight);

                    if (objNode.strData == "+") Result = Left + Right;
                    else if (objNode.strData == "-") Result = Left - Right;
                    else if (objNode.strData == "*") Result = Left * Right;
                    else if (objNode.strData == "/") Result = Left / Right;
                    break;
                default:
                    Result = Convert.ToDouble(objNode.strData);
                    break;
            }

            return Result;
        }
    }
}
