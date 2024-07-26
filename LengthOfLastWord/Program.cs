class Solution
{
    public static void Main()
    {
        var Result = LengthOfLastWord("XXV VF XXV  ");
        Console.WriteLine(Result);
    }

    private static int LengthOfLastWord(string s) 
    {
        s = s.Trim();
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string lastword = words.Length > 0 ? words[^1] : string.Empty;

        return lastword.Length;
    }
}