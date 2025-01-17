namespace Item0058;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Console.WriteLine(new Program().LengthOfLastWord("a bb ccc dddd"));
        Console.WriteLine(new Program().LengthOfLastWord("a bb ccc dddd "));
        Console.WriteLine(new Program().LengthOfLastWord(" a bb ccc dddd"));
        Console.WriteLine(new Program().LengthOfLastWord(" a bb ccc dddd "));
        Console.WriteLine(new Program().LengthOfLastWord(" a   bb   ccc  dddd  "));
        Console.WriteLine(new Program().LengthOfLastWord(" a   bb   ccc   dddd    "));
    }
    
    public int LengthOfLastWord(string s)
    {
        int index = s.Length - 1;
        int wordLength = 0;
        char[] chars = s.ToCharArray();
        while (index>=0 && chars[index] == ' ')
        {
            index--;
        }
        
        while (index>=0 && chars[index] != ' ')
        {
            wordLength++;
            index--;
        }

        return wordLength;
    }
}