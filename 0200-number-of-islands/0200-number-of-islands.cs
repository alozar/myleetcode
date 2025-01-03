public class Solution
{
    public int NumIslands(char[][] grid)
    {
        Queue<int[]> queue = new();
        int count = 0;
        int[][] directions = [[1, 0], [-1, 0], [0, 1], [0, -1]];
        int[] point;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0 ; j < grid[i].Length; j++)
            {
                if (grid[i][j].Equals('1'))
                {
                    queue.Enqueue([i, j]);
                    count++;
                    while (queue.Count > 0)
                    {
                        point = queue.Dequeue();
                        if (point[0] < 0 || point[0] >= grid.Length
                            || point[1] < 0 || point[1] >= grid[i].Length
                            || grid[point[0]][point[1]].Equals('0'))
                        {
                            continue;
                        }
                        // Помечаем посещенным
                        grid[point[0]][point[1]] = '0';
                        foreach (int[] direction in directions)
                        {
                            if (point[0] + direction[0] >= 0
                                && point[0] + direction[0] < grid.Length
                                && point[1] + direction[1] >= 0
                                && point[1] + direction[1] < grid[i].Length
                                && grid[point[0] + direction[0]][point[1] + direction[1]].Equals('1'))
                            {
                                queue.Enqueue([point[0] + direction[0], point[1] + direction[1]]);
                            }
                        }
                    }
                }
            }
        }
        return count;
    }
}