using ChallengeApp;

Employee employee1 = new Employee("Jan", "Nowak");
employee1.AddGrade(2.5f);
employee1.AddGrade("3");
employee1.AddGrade('5');
employee1.AddGrade(2);
employee1.AddGrade(4.5d);

//var stats = employee1.GetStatistics();
//Console.WriteLine($"Average: {stats.Average:N2}");
//Console.WriteLine($"Min: {stats.Min}");
//Console.WriteLine($"Max: {stats.Max}");

var stats1 = employee1.GetStatisticsWithForEach();
var stats2 = employee1.GetStatisticsWithFor();
var stats3 = employee1.GetStatisticsWithDoWhile();
var stats4 = employee1.GetStatisticsWithWhile();

Console.WriteLine($"Get Statistics With For Each: AVERAGE: {stats1.Average:N2}, MIN: {stats1.Min}, MAX: {stats1.Max}");
Console.WriteLine($"Get Statistics With For: AVERAGE: {stats2.Average:N2}, MIN: {stats2.Min}, MAX: {stats2.Max}");
Console.WriteLine($"Get Statistics With Do While: AVERAGE: {stats3.Average:N2}, MIN: {stats3.Min}, MAX: {stats3.Max}");
Console.WriteLine($"Get Statistics With While: AVERAGE: {stats4.Average:N2}, MIN: {stats4.Min}, MAX: {stats4.Max}");
