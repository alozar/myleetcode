public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var i = m - 1;
        var j = n - 1;
        int ind = m + n;
        while (j >= 0)
        {
            ind--;
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[ind] = nums1[i];
                i--;
            }
            else
            {
                nums1[ind] = nums2[j];
                j--;
            }
        }
    }
}