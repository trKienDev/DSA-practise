using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n1 = 19;
        int n2 = 2;

        Console.WriteLine($"Is {n1} a happy number? {IsHappy(n1)}");
        Console.WriteLine($"Is {n2} a happy number? {IsHappy(n2)}");
    }

    public static bool IsHappy(int n)
    {
        var seen = new HashSet<int>();

        while (n != 1)
        {
            if (!seen.Add(n))
            {
                // n đã xuất hiện trước đó → vòng lặp
                return false;
            }

            n = SumOfSquares(n);
        }

        return true;
    }

    private static int SumOfSquares(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }

        return sum;
    }
}
