using NUnit.Framework;

namespace InterviewProject.UnitTests
{
    [TestFixture]
    public class FizzBuzzUnitTests
    {
        private readonly FizzBuzz _fizzbuzz;

        public FizzBuzzUnitTests()
        {
            _fizzbuzz = new FizzBuzz();
        }

        [Test]
        public void ItReturnsFizz_WhenNumberIsDivisibleBy3()
        {
            var result = _fizzbuzz.Execute(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void ItReturnsBuzz_WhenNumberIsDivisibleBy5()
        {
            var result = _fizzbuzz.Execute(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void ItReturnsFizzBuzz_WhenNumberIsDivisibleBy3And5()
        {
            var result = _fizzbuzz.Execute(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void ItReturnsJustTheNumber_WhenNumberIsDivisibleByNeither3Nor5()
        {
            var result = _fizzbuzz.Execute(2);
            Assert.That(result, Is.EqualTo("2"));
        }
    }
}
