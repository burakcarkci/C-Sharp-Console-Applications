using System;

namespace ReverseString
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            //Reverse string with char array
            var reverseString = new StringReverserWithChar();
            string result1 = reverseString.CharReverse("burak ishak kerem");
            Console.WriteLine(result1);

            //Reverse string with stack
            var reverser = new StringReverserWithStack();
            var result2 = reverser.StackReverse("burak ishak kerem");
            Console.WriteLine(result2);
        }
    }
}