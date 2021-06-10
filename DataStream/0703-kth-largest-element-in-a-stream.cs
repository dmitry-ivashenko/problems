
// 703. Kth Largest Element in a Stream
// https://leetcode.com/problems/kth-largest-element-in-a-stream/
// Difficulty: Easy

public class KthLargest {
    PriorityQueue<int, int> data = new PriorityQueue<int, int>();
    int k;
    
    public KthLargest(int k, int[] nums) {
        this.k = k;
        foreach(var num in nums)
            Add(num);
    }
    
    public int Add(int val) {
        data.Enqueue(val, val);
        
        if(data.Count > k) 
            data.Dequeue();
        
        return data.Peek();
    }
}
        