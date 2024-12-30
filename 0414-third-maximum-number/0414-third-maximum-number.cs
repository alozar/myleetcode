public class Solution
{
    public int ThirdMax(int[] nums)
    {
        var arr = nums.Distinct().ToArray();
        Array.Sort(arr);
        if (arr.Length < 3)
        {
            return arr[arr.Length - 1];
        }
        return arr[arr.Length - 3];
    }
}