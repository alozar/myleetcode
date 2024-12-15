public class Solution {
    public IList<string> FizzBuzz(int n)
    {
        var answer = new List<string>(n);
        for (var i = 1; i <= n; i++)
        {
            answer.Add(
                i % 3 == 0 && i % 5 == 0 ? "FizzBuzz"
                : i % 3 == 0 ? "Fizz"
                : i % 5 == 0 ? "Buzz"
                : i.ToString());
        }
        return answer;
    }
}