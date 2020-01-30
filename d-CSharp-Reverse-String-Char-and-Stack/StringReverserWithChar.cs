using System;

namespace ReverseString
{
    public class StringReverserWithChar
    {
        public string CharReverse(string item)
        {
            char[] charArray = item.ToCharArray();
            string itemReversed = "";

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                itemReversed = itemReversed + charArray[i];
            }
            return itemReversed;
        }
    }
}