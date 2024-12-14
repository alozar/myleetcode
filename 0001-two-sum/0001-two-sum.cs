public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++) {
            dictionary[nums[i]] = i;
        }

        for (var i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            if (dictionary.TryGetValue(diff, out int diffIndex) && diffIndex != i) {
                return [i, diffIndex];
            }
        }

        return [];
    }
}