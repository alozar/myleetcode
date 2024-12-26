public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var index = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                continue;
            }
            if (index == i)
            {
                index++;
                continue;
            }
            nums[index] = nums[i];
            index++;
        }
        while (index < nums.Length)
        {
            nums[index] = 0;
            index++;
        }
    }
}