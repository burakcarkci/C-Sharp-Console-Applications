using System.Collections.Generic;

namespace ReverseString
{
    public class StringReverserWithStack
    {
        public string StackReverse(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                stack.Push(ch);
            }

            string reversed = "";

            while (stack.Count != 0)
            {
                reversed = reversed + stack.Pop();
            }
            return reversed;
        }
    }
}