public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        int evenIndex = 0;
        int oddIndex = nums.Length - 1;
        int temp = 0;
        while (evenIndex < oddIndex)
        {
            if (nums[evenIndex] % 2 == 0)
            {
                evenIndex++;
                continue;
            }

            if (nums[oddIndex] % 2 == 1)
            {
                oddIndex--;
                continue;
            }

            temp = nums[evenIndex];
            nums[evenIndex] = nums[oddIndex];
            nums[oddIndex] = temp;
            evenIndex++;
            oddIndex--;
        }
        return nums;
    }
}