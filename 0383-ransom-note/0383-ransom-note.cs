public class Solution {
    private Dictionary<char, int> StringToLetterDictionary(string str)
    {
        var letterDictionary = new Dictionary<char, int>();
        foreach (var letter in str)
        {
            if (!letterDictionary.TryAdd(letter, 1))
            {
                letterDictionary[letter] += 1;
            }
        }

        return letterDictionary;
    }

    public bool CanConstruct(string ransomNote, string magazine)
    {
        var ransomNoteDic = StringToLetterDictionary(ransomNote);
        var magazineDic = StringToLetterDictionary(magazine);

        foreach (var ransomNotePair in ransomNoteDic)
        {
            if (!magazineDic.ContainsKey(ransomNotePair.Key)
                || ransomNotePair.Value > magazineDic[ransomNotePair.Key])
            {
                return false;
            }
        }

        return true;
    }
}