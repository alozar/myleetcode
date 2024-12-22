public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var ind = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[ind] == nums[i])
            {
                continue;
            }
            ind++;
            nums[ind] = nums[i];
        }
        return ind + 1;
    }
}