public class Solution {
    public bool IsPalindrome(int x) {
        //var xString = x.ToString();
        //var xReverseString = new string(xString.Reverse().ToArray());
        //return xString.Equals(xReverseString);

        if (x < 0)
        {
            return false;
        }  

        List<int> reverseDigits = new ();
        while (x != 0)
        {
            reverseDigits.Add(x % 10);
            x /= 10;
        }

        for (var i = 0; i < reverseDigits.Count / 2; i++)
        {
            if (reverseDigits[i] != reverseDigits[reverseDigits.Count - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}