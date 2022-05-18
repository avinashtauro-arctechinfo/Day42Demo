using System.Collections;
using System.Collections.Specialized;

namespace Day42Demo.BoxingDemo;

public static class BoxingUnboxingTest
{
    public static void TestBoxing()
    {
        int val = 2019;

        // Boxing
        object o = val;

        // Change the value of val
        val = 2000;

        Console.WriteLine($"val = {val}");
        Console.WriteLine($"o = {o}");
    }

    public static void TestUnboxing()
    {
        int val = 2019;

        // Boxing
        object o = val;

        val++;

        // Unboxing
        int x = (int)o;

        o = 2021;

        Console.WriteLine($"val = {val}");  // 2020
        Console.WriteLine($"o = {o}");      // 2021
        Console.WriteLine($"x = {x}");      // 2019
    }
}