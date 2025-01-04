public class Solution {
    public int NumSquares(int n) {
        Queue<int> queue = new([0]);
        HashSet<int> sums = [];
        for (int count = 0; queue.Count > 0; count++)
        {
            int currentSize = queue.Count;
            while (currentSize > 0)
            {
                currentSize--;
                int sum = queue.Dequeue();
                for (int i = 1; i * i <= n; i++)
                {
                    if (sum + i * i == n)
                    {
                        return count + 1;
                    }
                    if (sum + i * i < n && sums.Add(sum + i * i))
                    {
                        queue.Enqueue(sum + i * i);
                    }
                }
            }
        }

        return n;
    }
}