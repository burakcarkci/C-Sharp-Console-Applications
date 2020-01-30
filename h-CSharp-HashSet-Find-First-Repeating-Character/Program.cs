using System;

namespace Exercises
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var set = new FindRepeatedChar();
            var ch = set.FindFirstRepeatedChar("a green apple");
            Console.WriteLine("First repeated character is: " + ch);
        }
    }
}