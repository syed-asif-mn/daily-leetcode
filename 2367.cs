public class Solution
{
    public int ArithmeticTriplets(int[] nums, int diff)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int count = 0;

        foreach (int num in nums)
        {
            if (set.Contains(num + diff) && set.Contains(num + 2 * diff))
            {
                count++;
            }
        }

        return count;
    }
}
