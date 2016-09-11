// Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/

using System.Collections.Generic;

namespace SumitGouthaman.LeetcodeSolutions
{
    public class Sol003
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 2)
                return s.Length;

            IDictionary<char, int> charMap = new Dictionary<char, int>();
            int maxLength = 0;
            int leftMostWindowIndex = -1;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (!charMap.ContainsKey(c) || charMap[c] < leftMostWindowIndex)
                {
                    if (charMap.ContainsKey(c))
                        charMap.Remove(c);

                    charMap.Add(c, i);
                    int newLength = i - leftMostWindowIndex;
                    maxLength = (newLength > maxLength) ? newLength : maxLength;
                }
                else
                {
                    int charIndex = charMap[c];
                    charMap.Remove(c);
                    charMap.Add(c, i);
                    leftMostWindowIndex = charIndex;
                }
            }

            return maxLength;
        }
    }
}
