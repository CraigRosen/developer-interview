using NUnit.Framework;
using Mednax.DeveloperInterview.TDD;

namespace Tests
{
    [TestFixture]
    public class FizzBuzzUnitTests
    {
        internal FizzBuzz _uit;

        [SetUp]
        public void Setup()
        {
            _uit = new FizzBuzz();
        }
       

        [Test]
        [TestCase(16, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16", "Up to 16")]
        [TestCase(100, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16", "Up to 100")]
        public void DoTests(int number, string expected, string testCase)
        {
            //Arrange

            //Act
            var result = _uit.PrintNumbers(number);

            //Assert
            Assert.AreEqual(expected, result.Substring(0, expected.Length), testCase);
        }
    }
}