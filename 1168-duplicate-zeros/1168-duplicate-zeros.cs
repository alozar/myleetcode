public class Solution {
    public void DuplicateZeros(int[] arr) {
        int[] clone = (int[])arr.Clone();
        var index = 0;
        for (int i = 0; index < clone.Length; i++)
        {
            if (clone[i] == 0)
            {
                arr[index] = 0;
                index++;
                if (index < clone.Length)
                {
                    arr[index] = 0;
                    index++;
                }
            }
            else
            {
                arr[index] = clone[i];
                index++;
            }
        }
    }
}