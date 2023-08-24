namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void MinGrade()
        {
            //arrange
            var employee = new Employee("Marcin", "Kowal");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);

            //act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(1f, result.Min);

        }

        [Test]
        public void MaxGrade()
        {
            //arrange
            var employee = new Employee("Dariusz", "Mazurek");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(9);

            //act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(9f, result.Max);

        }

        [Test]
        public void AverageGrade()
        {
            //arrange
            var employee = new Employee("Kamil", "Kozak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(3.33,2), Math.Round(result.Average,2));

        }

    }
}