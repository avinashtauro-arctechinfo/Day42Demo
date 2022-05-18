public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int Marks { get; set; }

    public override bool Equals(object obj)
    {
        var studentOnRight = obj as Student;

        var isEqual = RollNumber == studentOnRight.RollNumber && 
            Name == studentOnRight.Name && 
            Email == studentOnRight.Email && 
            Marks == studentOnRight.Marks;

        return isEqual;
    }
}