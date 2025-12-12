class Program
{
    static void Main()
    {
        int[] nums = { 4, 1, 2, 1, 2 };

        int result = SingleNumber(nums);

        Console.WriteLine("Single number is:");
        Console.WriteLine(result);
    }

    public static int SingleNumber(int[] nums)
    {
        int result = 0;

        foreach (var n in nums)
        {
            result ^= n;
        }

        return result;
    }
}
