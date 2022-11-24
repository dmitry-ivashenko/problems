
// 448. Find All Numbers Disappeared in an Array
// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
// Difficulty: Easy

public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        for(int i = 0; i < nums.Length; i++) {
            int index = Math.Abs(nums[i]) - 1;
            nums[index] = -Math.Abs(nums[index]);
        }
        List<int> result = new List<int>();
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] > 0) {
                result.Add(i + 1);
            }
        }
        return result;
    }
}
        