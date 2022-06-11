
// 50. Pow(x, n)
// https://leetcode.com/problems/powx-n/
// Difficulty: Medium

public class Solution
{
    public double MyPow(double x, long n)
    {
        var result = helper(x, Math.Abs(n));
        return n > 0 ? result : 1 / result;
    }

    private double helper(double x, long n)
    {
        if (x == 0) return 0;
        if (n == 0) return 1;

        var result = helper(x, n / 2);
        result = result * result;
        return n % 2 == 1 ? x * result : result;
    }
}
        