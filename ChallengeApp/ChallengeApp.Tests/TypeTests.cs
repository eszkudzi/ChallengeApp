namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestIntValue()
        {
            //arrange
            int integer1 = 5;
            int integer2 = 5;

            //assert
            Assert.AreEqual(integer1, integer2);

        }

        [Test]
        public void TestFloatValue()
        {
            //arrange
            float float1 = 5;
            float float2 = 5;

            //assert
            Assert.AreEqual(float1, float2);

        }

        [Test]
        public void TestBooleanValue()
        {
            //arrange
            bool boolean1 = true;
            bool boolean2 = true;

            //assert
            Assert.AreEqual(boolean1, boolean2);

        }

        [Test]
        public void TestCharValue()
        {
            //arrange
            char char1 = 'a';
            char char2 = 'a';

            //assert
            Assert.AreEqual(char1, char2);

        }

        [Test]
        public void TestStringValue()
        {
            //arrange
            string string1 = "a";
            string string2 = "a";

            //assert
            Assert.AreEqual(string1, string2);

        }

        [Test]
        public void TestReferenceType()
        {
            //arrange
            var employee1 = new Employee("Dariusz", "Mazurek", 44);
            var employee2 = new Employee("Dariusz", "Mazurek", 44);

            //assert
            Assert.AreNotEqual(employee1, employee2);

        }

    }
}
