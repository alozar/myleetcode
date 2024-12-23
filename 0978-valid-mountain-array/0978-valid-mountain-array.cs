public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if (arr is null || arr.Length < 2)
        {
            return false;
        }

        int peakIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] == arr[i])
            {
                return false;
            }

            if (arr[i - 1] < arr[i] && peakIndex == i - 1)
            {
                peakIndex = i;
                continue;
            }

            if (arr[i - 1] > arr[i] && peakIndex > 0)
            {
                continue;
            }

            return false;
        }

        return true && peakIndex < arr.Length - 1;
    }
}