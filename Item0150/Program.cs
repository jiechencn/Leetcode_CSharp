namespace Item0150;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(new Program().RomanToInt("LVIII"));
        Console.WriteLine(new Program().RomanToInt("MCMXCIV"));
    }

    private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    
    public int RomanToInt(string s)
    {
        int result = 0;
        int len = s.Length;
        char[] chars = s.ToCharArray();
        for (int i = 0; i < len; i++)
        {
            int currentIntValue = RomanMap[chars[i]];
            if (i < len - 1 && currentIntValue < RomanMap[chars[i + 1]])
            {
                result -= currentIntValue;
            }
            else
            {
                result += currentIntValue;
            }
        }

        return result;
    }
}