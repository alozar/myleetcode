public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int index = 0;
        int currentMax = 0;
        for (int i = arr.Length - 1; i + 1 > index; i--)
        {
            if (index == arr.Length - 1)
            {
                break;
            }
            if (currentMax < arr[i] && i > index)
            {
                currentMax = arr[i];
            }
            if (index == i)
            {
                arr[i] = currentMax;
                index++;
                i = arr.Length;
                currentMax = 0;
            }
        }
        arr[index] = -1;
        return arr;
    }
}