namespace Leetcode.Utility;

public static class CollectionExtention
{

    public static void PrintAll<T>(this IEnumerable<T> elements)
    {
        foreach (var item in elements)
        {
            Console.Write($"{item},");
        }
        Console.WriteLine();
    }
}
