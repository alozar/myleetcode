public class Solution {
    public bool IsValid(string s) {
        Stack<char> stacks = new([s[0]]);
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == '(' ||  s[i] == '[' || s[i] == '{')
            {
                stacks.Push(s[i]);
                continue;
            }
            if (stacks.Count > 0 &&
                (s[i] == ')' && stacks.Peek() == '('
                || s[i] == ']' && stacks.Peek() == '['
                || s[i] == '}' && stacks.Peek() == '{'))
            {
                stacks.Pop();
                continue;
            }
            return false;
        }
        return stacks.Count == 0;
    }
}