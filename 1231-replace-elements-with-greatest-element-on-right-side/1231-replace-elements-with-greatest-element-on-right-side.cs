public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int max = -1;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            var temp = arr[i];
            arr[i] = max;
            if (temp > max)
            {
                max = temp;
            }
        }
        return arr;
    }
}