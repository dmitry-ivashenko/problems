
// 678. Valid Parenthesis String
// https://leetcode.com/problems/valid-parenthesis-string/
// Difficulty: Medium

public class Solution
{
    //T: O(N) , S: O(1)
    public bool CheckValidString(string s)
    {
        var leftMax = 0;
        var leftMin = 0;

        foreach (var ch in s)
        {
            if (ch == '(')
            {
                leftMin++;
                leftMax++;
            }
            else if (ch == ')')
            {
                leftMax--;
                leftMin--;
            }
            else
            {
                leftMin--;
                leftMax++;
            }

            if (leftMax < 0)
                return false;

            if (leftMin < 0)
                leftMin = 0;

        }

        return leftMin == 0;
    }
}
        