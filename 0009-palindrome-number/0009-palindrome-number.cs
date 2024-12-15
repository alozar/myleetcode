public class Solution {
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int revertedHalfNumber = 0;
        while (x > revertedHalfNumber)
        {
            revertedHalfNumber = revertedHalfNumber * 10 + x % 10;
            x /= 10;
        }

        return x == revertedHalfNumber || x == revertedHalfNumber / 10;
    }
}