using Faker;

namespace Day42Demo.DictionaryDemo;

public static class DictionaryTest
{
    public static void Test()
    {
        const int rollNoToFind = 99999;

        var students = Test1WithList();

        // Very slow - Linear Search
        var studentToFind = students.SingleOrDefault(s => s.RollNumber == rollNoToFind);

        if (studentToFind != null)
            Console.WriteLine(studentToFind);
        else
            Console.WriteLine($"Roll No: {rollNoToFind} not found in the database");


        var students2 = Test2WithDictionary();

        // Exponentially Faster - Binary Search
        var student2ToFind = students2[rollNoToFind];

        if (student2ToFind != null)
            Console.WriteLine(student2ToFind);
        else
            Console.WriteLine($"Roll No: {rollNoToFind} not found in the database");
    }

    private static Dictionary<int, Student> Test2WithDictionary()
    {
        var students = new Dictionary<int, Student>();

        for (var i = 1; i <= 1000; i++)
        {
            var student = new Student
            {
                RollNumber = 100 + i,
                Name = Faker.Name.FullName(NameFormats.WithPrefix),
                Email = Faker.Internet.Email(),
                Marks = Faker.RandomNumber.Next(25, 100)
            };

            students.Add(student.RollNumber, student);
        }

        return students;
    }

    private static List<Student> Test1WithList()
    {
        var students = new List<Student>();

        for (var i = 1; i <= 1000; i++)
        {
            var student = new Student
            {
                RollNumber = 100 + i,
                Name = Faker.Name.FullName(NameFormats.WithPrefix),
                Email = Faker.Internet.Email(),
                Marks = Faker.RandomNumber.Next(25, 100)
            };

            students.Add(student);
        }

        return students;
    }
}