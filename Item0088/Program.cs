namespace Leetcode.Item0088;

using Leetcode.Utility;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var nums1 = new int[] { 2, 3, 4, 5, 7, 9 };
        var nums2 = new int[] { 1, 3, 5, 7, 9 };
        new Program().Merge(nums1, 3, nums2, 2);

        nums1.PrintAll();

    }
    public void Merge(int[] num1, int m, int[] num2, int n)
    {
        int p1 = m - 1;
        int p2 = n - 1;
        int tail = m + n - 1;
        int curVal;
        while (p1 >= 0 || p2 >= 0)
        {
            if (p1 == -1)
            {
                curVal = num2[p2--];
            }
            else if (p2 == -1)
            {
                curVal = num1[p1--];
            }
            else if (num1[p1] > num2[p2])
            {
                curVal = num1[p1--];
            }
            else
            {
                curVal = num2[p2--];
            }

            num1[tail--] = curVal;
        }
    }
}
