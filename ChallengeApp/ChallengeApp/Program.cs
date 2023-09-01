using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny Pracowników");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

var employee = new EmployeeInFile("Ewa", "Gileta");

employee.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę.");
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);

    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch: {e.Message}");
    }

}

var stats = employee.GetStatistics();
Console.WriteLine($"Average: {stats.Average:N2}");
Console.WriteLine($"AverageLetter: {stats.AverageLetter}");
Console.WriteLine($"Min: {stats.Min}");
Console.WriteLine($"Max: {stats.Max}");
