using Leetcode.Utility;

namespace Leetcode.Array.Item0027;


internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = new[] { 1, 2, 3, 2, 2, 3, 3, 4, 6, 7, 3 };
        Program p = new Program();
        int n = p.RemoveElement(nums, 3);

        nums.PrintAll();

        Console.WriteLine(n);
    }

    /// <summary>
    /// Time: O(n)
    /// Space: O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public int RemoveElement(int[] nums, int val)
    {
        int left = 0;
        int right = nums.Length;
        while (left < right) 
        {
            if (nums[left] == val)
            {
                nums[left] = nums[right-1];
                right--;
            }
            else
            {
                left++;
            }
        }
        return left;

    }
}
