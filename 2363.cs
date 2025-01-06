using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[][] MergeSimilarItems(int[][] items1, int[][] items2)
    {
        // Use a dictionary to sum weights for each unique value
        Dictionary<int, int> weightMap = new Dictionary<int, int>();

        // Process items1 and add to the dictionary
        foreach (var item in items1)
        {
            int value = item[0];
            int weight = item[1];

            if (weightMap.ContainsKey(value))
                weightMap[value] += weight;
            else
                weightMap[value] = weight;
        }

        // Process items2 and add to the dictionary
        foreach (var item in items2)
        {
            int value = item[0];
            int weight = item[1];

            if (weightMap.ContainsKey(value))
                weightMap[value] += weight;
            else
                weightMap[value] = weight;
        }

        // Convert the dictionary back to a sorted 2D array
        return weightMap.OrderBy(x => x.Key)
                        .Select(x => new int[] { x.Key, x.Value })
                        .ToArray();
    }
}
