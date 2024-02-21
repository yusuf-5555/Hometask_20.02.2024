using System.Diagnostics.CodeAnalysis;

var student1 = new Student()
{
    Name = "Rahmon Yusuf",
    GradeLevel = 11,
    TestScores = new int []{50,100,85,63,84}
};
var student2 = new Student()
{
    Name = "Rahmon Yusuf",
    GradeLevel = 11,
    TestScores = new int []{45,85,75,96,54}
};
var average1 = student1.GetAverage();

if(average1>=85)
{
    System.Console.WriteLine($"Congratulations {student1.Name} on achieving above average scores ({average1}) in grade {student1.GradeLevel}! Keep up the good work!");
}

public class Student
{
    public string Name;
    public int GradeLevel;
    public int[] TestScores;

    public double GetAverage()
    {
        int sum = 0;
        for(int i=0;i<TestScores.Length;i++)
        {
            sum +=TestScores[i];
        }
        return sum/(double) TestScores.Length;
    }
}