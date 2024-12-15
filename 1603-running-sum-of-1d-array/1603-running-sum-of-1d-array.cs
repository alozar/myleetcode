public class Solution {
    public int[] RunningSum(int[] nums) {
        var sumArray = new int[nums.Length];
        sumArray[0] = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            sumArray[i] = sumArray[i-1] + nums[i];
        }

        return sumArray;
    }
}