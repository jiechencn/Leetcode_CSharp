using Leetcode.Utility;

namespace Leetcode.Item0169;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] nums = { 1, 2, 3, 1, 2, 3, 3, 2, 3,3,3,3,4, 1, 1 };
        int max = new Program().MajorityElement(nums);

        nums.PrintAll();

        Console.WriteLine(max);

    }

    /// <summary>
    /// Time: O(n)
    /// Space: O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MajorityElement(int[] nums)
    {
        int max = nums[0];
        int vote = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == max)
            {
                vote++;
            }
            else{
                vote--;
                if (vote == 0)
                {
                    max = nums[i];
                    vote = 1;
                }
            }
        }

        return max;
    }
}
