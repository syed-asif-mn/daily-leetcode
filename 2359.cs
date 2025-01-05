public class Solution {
    public int ClosestMeetingNode(int[] edges, int node1, int node2) {
        // Helper function to calculate distances from a given node
        int[] GetDistances(int start)
        {
            int n = edges.Length;
            int[] distances = new int[n];
            Array.Fill(distances, -1); // Initialize distances to -1 (unreachable)
            int distance = 0;
            int current = start;

            while (current != -1 && distances[current] == -1)
            {
                distances[current] = distance;
                distance++;
                current = edges[current];
            }

            return distances;
        }

        // Get distances from node1 and node2
        int[] dist1 = GetDistances(node1);
        int[] dist2 = GetDistances(node2);

        // Find the node minimizing the maximum distance
        int minDistance = int.MaxValue;
        int result = -1;

        for (int i = 0; i < edges.Length; i++)
        {
            if (dist1[i] != -1 && dist2[i] != -1) // Node must be reachable from both
            {
                int maxDist = Math.Max(dist1[i], dist2[i]);
                if (maxDist < minDistance)
                {
                    minDistance = maxDist;
                    result = i;
                }
                else if (maxDist == minDistance && i < result)
                {
                    result = i;
                }
            }
        }

        return result;
    }
}
