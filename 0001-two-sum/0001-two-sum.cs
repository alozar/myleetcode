public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var index = 0;
        var i = 1;
        while (index < nums.Length - 1)
        {
            if (nums[index] + nums[i] == target)
            {
                return [index, i];
            }

            if (i < nums.Length - 1)
            {
                i++;
            }
            else
            {
                index++;
                i = index + 1;
            }
        }

        return [];
    }
}