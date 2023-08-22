namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void EmpolyeeHasOnlyNegativePoints()
        {
            //arrange
            var employee = new Employee("Marcin", "Kowal", 18);
            employee.AddScore(-1);
            employee.AddScore(-2);
            employee.AddScore(-3);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-6, result);

        }

        [Test]
        public void EmpolyeeHasOnlyPositivePoints()
        {
            //arrange
            var employee = new Employee("Dariusz", "Mazurek", 44);
            employee.AddScore(1);
            employee.AddScore(2);
            employee.AddScore(3);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(6, result);

        }

        [Test]
        public void EmpolyeeHasSumEqualZero()
        {
            //arrange
            var employee = new Employee("Dariusz", "Mazurek", 44);
            employee.AddScore(2);
            employee.AddScore(3);
            employee.AddScore(-2);
            employee.AddScore(-3);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(0, result);

        }

    }
}