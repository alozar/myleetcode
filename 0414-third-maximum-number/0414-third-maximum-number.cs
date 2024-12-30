public class Solution
{
    public int ThirdMax(int[] nums)
    {
        var list = nums.Distinct().ToList();
        list.Sort();
        if (list.Count < 3)
        {
            return list[list.Count - 1];
        }
        return list[list.Count - 3];
    }
}