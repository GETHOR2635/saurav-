using System;

namespace Assignment2_4;

class program
{
    static void Main(string[] args)
    {
        var List = new List<Student>
        {
            new Student()
            {
                Name = "John",
                Score = 86,
            },
            new Student()
            {
                Name = "Jane",
                Score = 95,
            },
            new Student()
            {
                Name = "Jim",
                Score = 58,
            },
            new Student()
            {
                Name = "Julie",
                Score = 78,
            },
        };
        
        
        Console.WriteLine("List of students:");
        foreach (var item in List)
        {
            Console.WriteLine($"Name: {item.Name}, Score: {item.Score}");
        }
        Console.WriteLine("=====================");
        
        var highscore = List.OrderByDescending(x => x.Score).First();
        Console.WriteLine($"Highscore: {highscore.Name}, Score: {highscore.Score}");
        Console.WriteLine("===================");
        var lowscore = List.OrderByDescending(x => x.Score).Last();
        
        Console.WriteLine($"Lowscore: {lowscore.Name}, Score: {lowscore.Score}");
        
            
        
    }
}

public class Student
{
    public string Name { get; set; }
    public int Score { get; set; }
}