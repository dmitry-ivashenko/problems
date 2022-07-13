
// 973. K Closest Points to Origin
// https://leetcode.com/problems/k-closest-points-to-origin/
// Difficulty: Medium

public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var items = points.Select(point => {
            long x = point[0];
            long y = point[1];

            return (point, x * x + y * y);
        });

        int[][] result = new int[k][];
        // T: O(n)
        PriorityQueue<int[], long> queue = new(items);

        // T: O(k log(n))
        for (int i = 0; i < k; i++) {
            result[i] = queue.Dequeue();
        }

        return result;
    }
}

        