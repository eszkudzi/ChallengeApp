using ChallengeApp;

Employee employee1 = new Employee("Jan", "Nowak", 21);
Employee employee2 = new Employee("Marian", "Kowalski", 33);
Employee employee3 = new Employee("Maciej", "Lipiec", 45);

employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(5);

employee2.AddScore(4);
employee2.AddScore(2);
employee2.AddScore(1);
employee2.AddScore(8);
employee2.AddScore(10);

employee3.AddScore(2);
employee3.AddScore(5);
employee3.AddScore(7);
employee3.AddScore(1);
employee3.AddScore(4);

List<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3 };

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var i in employees)
{
    if (i.Result > maxResult)
    {
        employeeWithMaxResult = i;
        maxResult = i.Result;
    }
}

Console.WriteLine("Pracownik z najwyższą punktacją: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + ", wiek: " + employeeWithMaxResult.Age + ", punkty: " + employeeWithMaxResult.Result);

