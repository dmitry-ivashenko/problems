
// 215. Kth Largest Element in an Array
// https://leetcode.com/problems/kth-largest-element-in-an-array/
// Difficulty: Medium

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
             PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        
        for(var i = 0; i < nums.Length; i++) {
            if (queue.Count < k)
                queue.Enqueue(nums[i], nums[i]);
            else {
                if (nums[i] <= queue.Peek()) continue;
                
                queue.Dequeue();
                queue.Enqueue(nums[i], nums[i]);
            }
        }
        return queue.Dequeue();
    }
}

        