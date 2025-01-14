public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        Stack<int> indexes = new();
        int[] days = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (indexes.Count !=0
                && temperatures[i] > temperatures[indexes.Peek()])
            {
                days[indexes.Peek()] = i - indexes.Pop();
            }
            indexes.Push(i);
        }
        return days;
    }
}