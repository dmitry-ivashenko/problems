
// 58. Length of Last Word
// https://leetcode.com/problems/length-of-last-word/
// Difficulty: Easy

public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.TrimEnd();
        string[] arr = s.Split(' ');
        return arr[arr.Length - 1].Length;
    }
}


        