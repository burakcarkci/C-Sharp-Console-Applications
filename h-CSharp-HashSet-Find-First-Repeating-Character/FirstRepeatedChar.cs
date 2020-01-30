using System.Collections.Generic;

namespace Exercises
{
    public class FindRepeatedChar
    {
        public char FindFirstRepeatedChar(string item)
        {
            HashSet<char> set = new HashSet<char>();

            foreach (var ch in item.ToCharArray())
            {
                if (set.Contains(ch))
                {
                    return ch;
                }
                else
                {
                    set.Add(ch);
                }
            }
            return char.MinValue;
        }
    }
}