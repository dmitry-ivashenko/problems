
// 28. Find the Index of the First Occurrence in a String
// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
// Difficulty: Easy

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length) return -1;

        int l = 0;
        int r = needle.Length - 1;

        while (r < haystack.Length)
        {
            bool areEqual = true;
            for (int i = l, j = 0; i <= r; i++, j++)
            {
                if (haystack[i] != needle[j])
                {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
            {
                return l;
            }

            l++;
            r++;
        }

        return -1;
    }
}
        