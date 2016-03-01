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

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void ItReturnsFizz_WhenNumberIsDivisibleBy3(int input)
        {
            var result = _fizzbuzz.Execute(input);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void ItReturnsBuzz_WhenNumberIsDivisibleBy5(int input)
        {
            var result = _fizzbuzz.Execute(input);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        [TestCase(60)]
        public void ItReturnsFizzBuzz_WhenNumberIsDivisibleBy3And5(int input)
        {
            var result = _fizzbuzz.Execute(input);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [TestCase(2)]
        [TestCase(8)]
        [TestCase(16)]
        public void ItReturnsJustTheNumber_WhenNumberIsDivisibleByNeither3Nor5(int input)
        {
            var result = _fizzbuzz.Execute(input);
            Assert.That(result, Is.EqualTo(input.ToString()));
        }
    }
}
