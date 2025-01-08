public class Solution
{
    public int MinMutation(string startGene, string endGene, string[] bank)
    {
        if (bank == null || bank.Length == 0 || !bank.Contains(endGene))
        {
            return -1;
        }
        Queue<string> mutations = new([startGene]);
        HashSet<string> visited = new([startGene]);
        char[] variations = ['A', 'C', 'G', 'T'];
        for (int count = 0; mutations.Count > 0; count++)
        {
            int size = mutations.Count;
            while (size > 0)
            {
                size--;
                string current = mutations.Dequeue();
                for (int i = 0; i < current.Length; i++)
                {
                    foreach (char variation in variations)
                    {
                        if (current[i] == variation)
                        {
                            continue;
                        }

                        char[] array = current.ToCharArray();
                        array[i] = variation;
                        string newMutation = new(array);

                        if (newMutation == endGene)
                        {
                            return count + 1;
                        }

                        if (bank.Contains(newMutation)
                            && !visited.Contains(newMutation))
                        {
                            visited.Add(newMutation);
                            mutations.Enqueue(newMutation);
                        }
                    }
                }
            }
        }    
        return -1;
    }
}