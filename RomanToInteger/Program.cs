class Solution
{
    public static void Main()
    {
        var Result = RomanToInt("XXV");
        Console.WriteLine(Result);
    }

    private static int RomanToInt(string s) 
    {
        Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        return ConvertRomanToInt(s, dict);
    }

    private static int ConvertRomanToInt(string s, Dictionary<char, int> dict)
    {
        int total = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            char currentChar = s[i];
            dict.TryGetValue(currentChar, out int currentValue);

            if (currentValue < prevValue)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
            }

            prevValue = currentValue;
        }

        return total;
    }
}