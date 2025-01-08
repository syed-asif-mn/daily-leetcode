using System;

public class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length;
        int[][] maxLocal = new int[n - 2][];
        
        // Initialize the result array
        for (int i = 0; i < n - 2; i++)
        {
            maxLocal[i] = new int[n - 2];
        }
        
        // Iterate over the grid to compute the maximum in each 3x3 subgrid
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < n - 2; j++)
            {
                int maxVal = int.MinValue;
                
                // Check the 3x3 matrix centered at (i+1, j+1)
                for (int x = i; x < i + 3; x++)
                {
                    for (int y = j; y < j + 3; y++)
                    {
                        maxVal = Math.Max(maxVal, grid[x][y]);
                    }
                }
                
                maxLocal[i][j] = maxVal;
            }
        }
        
        return maxLocal;
    }
}
