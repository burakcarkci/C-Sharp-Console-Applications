using System.Collections.Generic;
using System.Text;

namespace BalancedExpressions
{
    ///Given an input string with unbalanced parantheses, make it balanced
    //    (() => ()
    //    (()) => (())
    //    ))(( => ""
    //    ())) => ()
    //    )( = ""
    //    )() = ()

    public class Decision
    {
        public char Ch { get; set; }
        public int Idx { get; set; }

        public string ReturnBalanced(string item)
        {
            var len = item.Length;
            var decisions = new bool[item.Length];
            var stack = new Stack<Decision>();
            for (int i = 0; i < item.Length; i++)
            {
                if (stack.Count == 0 || item[i] == '(')
                {
                    stack.Push(new Decision() { Ch = item[i], Idx = i });
                }
                else if (stack.Peek().Ch == '(' && item[i] == ')')
                {
                    var top = stack.Pop();
                    decisions[i] = true;
                    decisions[top.Idx] = true;
                }
            }
            var sb = new StringBuilder();
            for (int i = 0; i < item.Length; i++)
            {
                if (decisions[i])
                {
                    sb.Append(item[i]);
                }
            }
            return sb.ToString();
        }
    }
}