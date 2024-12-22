public class Solution
{
    public int RomanToInt(string s)
    {
        var romanDic = new Dictionary<char, int>()
        {
            {'I', 1 }, {'V', 5 }, {'X', 10 }, {'L', 50 },
            {'C', 100 }, {'D', 500 }, {'M', 1000 }
        };

        var result = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length)
            {
                if (romanDic[s[i]] < romanDic[s[i + 1]])
                {
                    result += romanDic[s[i + 1]] - romanDic[s[i]];
                    i++;
                    continue;
                }
            }
            result += romanDic[s[i]];
        }

        return result;
    }
}