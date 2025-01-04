public class Solution
{
    public int OpenLock(string[] deadends, string target) {
        HashSet<string> visited = new(deadends);
        if (visited.Contains("0000"))
        {
            return -1;
        }
        Queue<string> queue = new(["0000"]);
        for (int count = 0; queue.Count > 0; count++)
        {
            int currentSize = queue.Count;
            while (currentSize > 0)
            {
                currentSize--;
                string code = queue.Dequeue();
                if (code.Equals(target))
                {
                    return count;
                }
                for (int i = 0; i < code.Length; i++)
                {
                    foreach (int step in new[] { 1, -1 })
                    {
                        char[] codeChars = code.ToCharArray();
                        if (step == 1)
                        {
                            if (codeChars[i] == '9')
                            {
                                codeChars[i] = '0';
                            }
                            else
                            {
                                codeChars[i]++;
                            }
                        }
                        if (step == -1)
                        {
                            if (codeChars[i] == '0')
                            {
                                codeChars[i] = '9';
                            }
                            else
                            {
                                codeChars[i]--;
                            }
                        }
                        string newCode = new string(codeChars);
                        if (visited.Contains(newCode))
                        {
                            continue;
                        }
                        visited.Add(newCode);
                        queue.Enqueue(newCode);
                    }
                }
            }
        }
        return -1;
    }
}