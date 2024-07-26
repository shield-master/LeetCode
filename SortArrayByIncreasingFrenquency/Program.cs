class Solution
{
    public static void Main()
    {
        var Result = SortArray([3,1,4,5]);
        Console.WriteLine(Result);
    }

    private static int[] SortArray(int[] nums)
    {
        Dictionary<int, int> numsCount = new Dictionary<int, int>();
        List<int> sortedList = new List<int>();

        foreach (int num in nums)
        {
            if (numsCount.TryGetValue(num, out int value))
            {
                numsCount[num] = value + 1;
            }
            else
            {
                numsCount.Add(num, 1);
            }
        }

        var sortedDict = numsCount.OrderBy(kvp => kvp.Value)
                                  .ThenByDescending(kvp => kvp.Key);

        foreach (var kvp in sortedDict)
        {
            for (int i = 0; i < kvp.Value; i++)
            {
                sortedList.Add(kvp.Key);
            }
        }


        return sortedList.ToArray();
    }
}