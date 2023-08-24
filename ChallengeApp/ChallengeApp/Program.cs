using ChallengeApp;

Employee employee1 = new Employee("Jan", "Nowak");
employee1.AddGrade(2.5f);
employee1.AddGrade("3");
employee1.AddGrade('5');
employee1.AddGrade(2);
employee1.AddGrade(4.5d);

var stats = employee1.GetStatistics();

Console.WriteLine($"Average: {stats.Average:N2}");
Console.WriteLine($"Min: {stats.Min}");
Console.WriteLine($"Max: {stats.Max}");