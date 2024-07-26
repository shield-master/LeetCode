class Solution
{
    public static void Main()
    {
        var Result = SortArray([3,1,4,5]);
        Console.WriteLine(Result);
    }

    private static int[] SortArray(int[] nums)
    {
        Array.Sort(nums);
        return nums;
    }
}