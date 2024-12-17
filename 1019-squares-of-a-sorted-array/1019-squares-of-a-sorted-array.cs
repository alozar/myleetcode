public class Solution {
    public int[] SortedSquares(int[] nums) {
        var result = new int[nums.Length];
        int i = 0;
        int j = nums.Length - 1;
        for (int k = j; k >= 0; k--)
        {
            if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
            {
                result[k] = nums[i] * nums[i];
                i++;
            }
            else
            {
                result[k] = nums[j] * nums[j];
                j--;
            }
        }
        return result;
    }
}