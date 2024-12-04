using Leetcode.Utility;

namespace Leetcode.Array.Item0026;


internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] nums = { 1,1,1,1,1, 2,2,3,3,3,3,3, 3, 4, 5, 6, 7 };

        Program p = new Program();
        int k = p.RemoveDuplicates(nums);

        nums.PrintAll();
    }

    /// <summary>
    /// Time: O(n)
    /// Space: O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <=1)
        {
            return nums.Length;
        }

        int p1 = 0;
        int p2 = 1;
        while (p2< nums.Length)
        {
            if (nums[p2] == nums[p1])
            {
                p2++;
            }
            else
            {
                nums[++p1] = nums[p2];
            }
        }

        return p1+1;
    }

}
