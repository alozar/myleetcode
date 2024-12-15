public class Solution {
    public int MaximumWealth(int[][] accounts) {
        var wealth = 0;
        for (var i = 0; i < accounts.Length; i++)
        {
            var sumAccountCustomer = 0;
            for (var j = 0; j < accounts[i].Length; j++)
            {
                sumAccountCustomer += accounts[i][j];
            }
            if (wealth < sumAccountCustomer)
            {
                wealth = sumAccountCustomer;
            }
        }
        return wealth;
    }
}