using System.Linq;
public class Solution {
    public int MaximumGroups(int[] grades) {
        Array.Sort(grades);

        int totalStudents = grades.Length;
        int groupCount = 0;
        int currentSize = 1;

        while (totalStudents >= currentSize)
        {
            totalStudents -= currentSize;
            groupCount++;
            currentSize++;
        }

        return groupCount;
    }
}
