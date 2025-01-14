public class Solution
{
    public int MinimumRecolors(string blocks, int k)
    {
        int n = blocks.Length;
        int minOperations = k; // Start with the maximum possible operations (all 'W' in a window of size k)
        int currentWhiteCount = 0;

        // Count the number of 'W' in the first window of size k
        for (int i = 0; i < k; i++)
        {
            if (blocks[i] == 'W')
            {
                currentWhiteCount++;
            }
        }

        // Set the initial minOperations
        minOperations = currentWhiteCount;

        // Slide the window across the string
        for (int i = k; i < n; i++)
        {
            // Update the white count:
            // Remove the effect of the block leaving the window
            if (blocks[i - k] == 'W')
            {
                currentWhiteCount--;
            }

            // Add the effect of the block entering the window
            if (blocks[i] == 'W')
            {
                currentWhiteCount++;
            }

            // Update the minimum operations
            minOperations = Math.Min(minOperations, currentWhiteCount);
        }

        return minOperations;
    }
}
