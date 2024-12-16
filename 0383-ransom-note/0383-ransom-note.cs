public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineDic = new Dictionary<char, int>();
        foreach (var letter  in magazine)
        {
            var letterCount = magazineDic.GetValueOrDefault(letter, 0);
            magazineDic[letter] = letterCount + 1;
        }

        foreach (var letter in ransomNote)
        {
            var letterCount = magazineDic.GetValueOrDefault(letter, 0);
            if (letterCount == 0)
            {
                return false;
            }
            magazineDic[letter] = letterCount - 1;
        }

        return true;
    }
}