namespace Day42Demo.EqualsDemo;

public static class EqualsTest
{
    public static void Test()
    {
        TestString();
        TestStudent();
    }

    private static void TestString()
    {
        string s1 = "Hello1";
        string s2 = "Hello2";

        var isEqual1 = s1.Equals(s2);   // Value comparison
        var isEqual2 = (s1 == s2);      // Reference comparison

        Console.WriteLine($"TestString >> isEqual1 = {isEqual1}, isEqual2 = {isEqual2}");
        // false, false
    }

    private static void TestStudent()
    {
        var s1 = new Student {RollNumber = 100};
        var s2 = new Student { RollNumber = 100 };

        var isEqual1 = s1.Equals(s2); // Value comparison
        var isEqual2 = s1 == s2;      // Reference comparison

        Console.WriteLine($"TestStudent >> isEqual1 = {isEqual1}, isEqual2 = {isEqual2}");
        // false, true
    }
}