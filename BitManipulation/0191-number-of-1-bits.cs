
// 191. Number of 1 Bits
// https://leetcode.com/problems/number-of-1-bits/
// Difficulty: Easy

public class Solution {
    public int HammingWeight(uint n) {
        var binary = Convert.ToString(n, 2);
        var hammingWeight = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            hammingWeight += binary[i] - '0';
        }
        return hammingWeight;
    }
}
        