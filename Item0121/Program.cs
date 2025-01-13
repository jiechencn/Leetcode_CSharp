namespace Leetcode.Array.Item0121;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program p = new Program();
        
        int[] prices1 = { 1, 2, 3, 4, 5 };
        int profit1 = p.MaxProfit(prices1);
        Console.WriteLine($"Profit: {profit1}");
        
        int[] prices2 = { 7, 1, 5, 3, 6, 4 };
        int profit2 = p.MaxProfit(prices2);
        Console.WriteLine($"Profit: {profit2}");
        
        int[] prices3 = { 5, 4, 3, 2, 1 };
        int profit3 = p.MaxProfit(prices3);
        Console.WriteLine($"Profit: {profit3}");
        
    }
    
    public int MaxProfit(int[] prices)
    {
        int min = Int32.MaxValue;
        int profit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            } else if (prices[i] - min > profit)
            {
                profit = prices[i] - min;
            }
        }

        return profit;
    }
}