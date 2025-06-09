namespace TestProject1.GradeTests;

public class DatabaseGradesTableFixture
{
    public List<int> Grades { get; set; }

    public DatabaseGradesTableFixture()
    {
        Grades = new List<int>() { 10, 30, 77, 100, 5, 20, 46, 79 };
    }
}