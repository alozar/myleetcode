public class Solution
{
    public int ThirdMax(int[] nums)
    {
        HashSet<int> maxs = new(3);
        int thridMax = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (maxs.Count < 3)
            {
                maxs.Add(nums[i]);
                continue;
            }
            if (maxs.Contains(nums[i]))
            {
                continue;
            }
            thridMax = maxs.Min();
            if (thridMax < nums[i])
            {
                maxs.Remove(thridMax);
                maxs.Add(nums[i]);
            }
        }
        return maxs.Count < 3 ? maxs.Max() : maxs.Min();
    }
}