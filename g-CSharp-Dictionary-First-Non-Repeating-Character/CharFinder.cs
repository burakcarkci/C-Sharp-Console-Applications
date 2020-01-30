using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class CharFinder
    {
        public void FindFirstNonRepeatingChar(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (var ch in str)
            {
                if (map.ContainsKey(ch))
                {
                    map[ch]++;
                }
                else
                {
                    map.Add(ch, 1);
                }
            }

            var pair = map.FirstOrDefault(x => x.Value == 1).Key;

            Console.WriteLine("First non-repeating character: " + pair);
        }
    }
}