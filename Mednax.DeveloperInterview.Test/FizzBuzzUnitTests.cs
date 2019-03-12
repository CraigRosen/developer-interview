using NUnit.Framework;
using Mednax.DeveloperInterview.TDD;
using System.Linq;

namespace Tests
{
    //In the real world, I would use CollectionAssert on an expected object I store here.
    //Otherwise I would test more cases from 1 to 100 where I mentioned "etc".

    [TestFixture]
    public class FizzBuzzUnitTests
    {
        [Test]
        public void IFizzBuzz_DoFizzBuzz_ReturnsNotNull()
        {
            //Arrange
            IFizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.DoFizzBuzz();

            //Assert
            Assert.NotNull(result);
        }

        [Test]
        public void IFizzBuzz_DoFizzBuzz_Returns100Items()
        {
            //Arrange
            IFizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.DoFizzBuzz();

            //Assert
            Assert.AreEqual(100, result.Count());
        }

        [Test]
        public void IFizzBuzz_DoFizzBuzz_MultiplesOfThreeAreFizz()
        {
            //Arrange
            IFizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.DoFizzBuzz();

            //Assert
            Assert.AreEqual(FizzBuzz.FIZZ, result[2]);
            Assert.AreEqual(FizzBuzz.FIZZ, result[5]);
            Assert.AreEqual(FizzBuzz.FIZZ, result[8]);
            //etc
        }

        [Test]
        public void IFizzBuzz_DoFizzBuzz_MultiplesOfFiveAreBuzz()
        {
            //Arrange
            IFizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.DoFizzBuzz();

            //Assert
            Assert.AreEqual(FizzBuzz.BUZZ, result[4]);
            Assert.AreEqual(FizzBuzz.BUZZ, result[9]);
            //etc
        }

        [Test]
        public void IFizzBuzz_DoFizzBuzz_NonMultiplesOfThreeAndFiveAreUnchanged()
        {
            //Arrange
            IFizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.DoFizzBuzz();

            //Assert
            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("2", result[1]);
            Assert.AreEqual("4", result[3]);
            //etc
        }

        [Test]
        public void IFizzBuzz_DoFizzBuzz_MultiplesOfThreeAndFiveAreFizzBuzz()
        {
            //Arrange
            IFizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.DoFizzBuzz();

            //Assert
            Assert.AreEqual(FizzBuzz.FIZZBUZZ, result[14]);
            Assert.AreEqual(FizzBuzz.FIZZBUZZ, result[29]);
            //etc
        }
    }
}