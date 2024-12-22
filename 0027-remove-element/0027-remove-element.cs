public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var ind = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                continue;
            }
            if (i == ind)
            {
                ind++;
                continue;
            }
            nums[ind] = nums[i];
            ind++;
        }
        return ind;
    }
}