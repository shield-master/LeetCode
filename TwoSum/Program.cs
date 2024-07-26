class Solution
{
    public static void Main()
    {
        var Result = TwoSum([3,1,4,5], 6);
        Console.WriteLine(Result);
    }

    private static int[] TwoSum(int[] nums, int target)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            for(int g = i + 1; g < nums.Length; g++)
            {
                int answer = nums[i] + nums[g];
                if(answer == target)
                {
                    return [i,g];
                }
            }
        }
        return [0,0];
    }
}