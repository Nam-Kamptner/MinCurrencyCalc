// C# Implementation of a minimum Currency Calculator for Integer values.
using System;

public class MinCurrencyCalc
{
    static void Main()
    {
        int n = 81; // 1x 50, 1x 20, 1x 10, 1x 1 -> 4
        Console.WriteLine(MinCurrency(n));
        n = 1379;
        Console.WriteLine(MinCurrency(n));
        n = 0;
        Console.WriteLine(MinCurrency(n));
        n = 999;
        Console.WriteLine(MinCurrency(n));
        n = -12;
        Console.WriteLine(MinCurrency(n));
    }

    static int MinCurrency(int n)
    {
        int[] currency = [200, 100, 50, 20, 10, 5, 2, 1];
        int count = 0;

        foreach (int value in currency)
        {
            if (n >= value)
            {
                count += (n / value);
                n %= value;

            }

        }
        return count;
    }
}
