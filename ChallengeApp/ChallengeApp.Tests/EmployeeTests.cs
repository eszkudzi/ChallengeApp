namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void ReturnCorrectMinGrade()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(1);
            employee.AddGrade('2');
            employee.AddGrade(3.0);

            //act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(1f, result.Min);

        }

        [Test]
        public void ReturnCorrectMaxGrade()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(2.0);
            employee.AddGrade("4");
            employee.AddGrade('A');

            //act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(100f, result.Max);

        }

        [Test]
        public void ReturnCorrectAverageGrade()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(result.Average, 2));

        }

        [Test]
        public void ReturnCorrectAverageLetter()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(99);
            employee.AddGrade(89);
            employee.AddGrade(100);

            //act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual('A', result.AverageLetter);

        }



    }
}