public class Solution {
    public bool CheckIfExist(int[] arr) {
        if (arr == null || arr.Length == 0)
        {
            return false;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j] * 2 || arr[i] * 2 == arr[j])
                {
                    return true;
                }
            }
        }

        return false;
    }
}