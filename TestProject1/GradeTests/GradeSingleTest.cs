namespace TestProject1.GradeTests;

public class GradeSingleTest : IClassFixture<DatabaseGradesTableFixture>
{
    private readonly DatabaseGradesTableFixture _databaseGradesTableFixture;

    public GradeSingleTest(DatabaseGradesTableFixture databaseGradesTableFixture)
    {
        _databaseGradesTableFixture = databaseGradesTableFixture;
    }

    [Fact]
    public void Do_We_Have_Grades()
    {
        Assert.NotNull(_databaseGradesTableFixture.Grades);
    }

    [Fact]
    public void All_The_Grades_Are_Correct()
    {
        foreach (var grade in _databaseGradesTableFixture.Grades)
        {
            if (grade < 0 || grade > 100) throw new ArgumentOutOfRangeException($"{grade} notu geçerli aralıkta değil.");
        }
    }

    [Theory]
    [InlineData(45)]
    [InlineData(50)]
    public void Is_The_Average_Correct(int excepted)
    {
        var total = 0;
        foreach (var grade in _databaseGradesTableFixture.Grades)
        {
            total += grade;
        }
        var average = total / _databaseGradesTableFixture.Grades.Count;
        Assert.Equal(excepted, average);
    }
}