using Leetcode.Utility;
using System.Runtime.InteropServices;

namespace Leetcode.Array.Item0189;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int k = 3;
        new Program().Rotate(nums, k);
        nums.PrintAll();
    }

    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        Reverse(nums, 0, len - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k , len - 1);

    }
    private void Reverse(int[] nums, int start, int end)
    {
        while(start<end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
