using NUnit.Framework;

namespace InterviewProject.UnitTests
{
    [TestFixture]
    public class EvenFibonacciNumbersSumUnitTests
    {
        private readonly EvenFibonacciNumbersSum _evenFibonacciNumbers;

        public EvenFibonacciNumbersSumUnitTests()
        {
            _evenFibonacciNumbers = new EvenFibonacciNumbersSum();
        }

        [TestCase(10, 10)]
        [TestCase(50, 44)]
        [TestCase(100, 44)]
        [TestCase(1000000, 1089154)]
        [TestCase(4000000, 4613732)]
        public void ItReturnsCorrectValue(int upperLimit, int expectedResult)
        {
            var result = _evenFibonacciNumbers.Execute(upperLimit);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
