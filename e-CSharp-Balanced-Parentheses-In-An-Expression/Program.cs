using System;

namespace BalancedExpressions
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            //Return true if given expression is balanced else return false
            var myString = new BExpressions();
            var result = myString.CheckForBalance("{()}");
            Console.WriteLine(result);

            //Given an input string with unbalanced parantheses, make it balanced
            var bString = new Decision();
            var result2 = bString.ReturnBalanced("((()");
            Console.WriteLine(result2);
            result2 = bString.ReturnBalanced("(())");
            Console.WriteLine(result2);
            result2 = bString.ReturnBalanced("))((");
            Console.WriteLine(result2);
            result2 = bString.ReturnBalanced("()))");
            Console.WriteLine(result2);
            result2 = bString.ReturnBalanced(")(");
            Console.WriteLine(result2);
            result2 = bString.ReturnBalanced(")()");
            Console.WriteLine(result2);
        }
    }
}