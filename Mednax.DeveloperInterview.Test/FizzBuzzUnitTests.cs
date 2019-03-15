using NUnit.Framework;
using Mednax.DeveloperInterview.TDD;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class FizzBuzzUnitTests
    {
       [Test]
       public void ReturnsAList()
        {
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.GetResult();

            Assert.IsNotNull(result);
        }

        [Test]
        public void ReturnsNonEmptyList()
        {
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.GetResult();

            Assert.IsNotEmpty(result);
        }

        [Test]
        public void ListContainsFizz()
        {
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.GetResult();

            Assert.IsTrue(result.Contains("Fizz"));
        }

        [Test]
        public void ListContainsBuzz()
        {
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.GetResult();

            Assert.IsTrue(result.Contains("Buzz"));
        }

        [Test]
        public void ListContainsFizzBuzz()
        {
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.GetResult();

            Assert.IsTrue(result.Contains("FizzBuzz"));
        }

        [Test]
        public void FizzIsInCorrectPosition()
        {
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.GetResult();

            foreach (var it in result.Select((x, i) => new { Value = x, Index = i }))
            {
                if(it.Value == "Fizz")
                {
                    bool isMultipleOfThree = ((it.Index + 1) % 3 == 0);
                    Assert.IsTrue(isMultipleOfThree);
                }
            }
            
        }

        [Test]
        public void BuzzIsInCorrectPosition()
        {
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.GetResult();

            foreach (var it in result.Select((x, i) => new { Value = x, Index = i }))
            {
                if (it.Value == "Buzz")
                {
                    bool isMultipleOfFive = ((it.Index + 1) % 5 == 0);
                    Assert.IsTrue(isMultipleOfFive);
                }
            }
        }

        [Test]
        public void FizzBuzzIsInCorrectPosition()
        {
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.GetResult();

            foreach (var it in result.Select((x, i) => new { Value = x, Index = i }))
            {
                if (it.Value == "FizzBuzz")
                {
                    bool isMultipleOfThreeAndFive = ((it.Index + 1) % 5 == 0) && ((it.Index + 1) % 3 == 0);
                    Assert.IsTrue(isMultipleOfThreeAndFive);
                }
            }

        }


    }
}