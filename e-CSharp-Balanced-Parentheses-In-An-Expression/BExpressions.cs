using System.Collections.Generic;

namespace BalancedExpressions
{
    public partial class BExpressions
    {
        //Time Complexity: O(n) where n is the length of the string
        //Space Complexity: O(n) where n is the length of the string
        public bool CheckForBalance(string input)
        {
            var lenString = input.Length;

            var stack = new Stack<char>();

            for (int i = 0; i < lenString; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    stack.Push(input[i]);
                }
                else if (input[i] == ')' || input[i] == '}' || input[i] == ']')
                {
                    char top = stack.Peek();

                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else if (top == '(' && input[i] == ')' || top == '{' && input[i] == '}' || top == '[' && input[i] == ']')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(input[i]);
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}