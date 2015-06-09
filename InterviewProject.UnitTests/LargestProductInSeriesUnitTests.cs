using NUnit.Framework;

namespace InterviewProject.UnitTests
{
    [TestFixture]
    public class LargestProductInSeriesUnitTests
    {
        private readonly LargestProductInSeries _largestProductInSeries;

        public LargestProductInSeriesUnitTests()
        {
            _largestProductInSeries = new LargestProductInSeries();
        }

        [TestCase("03478234793", 252)]
        [TestCase("99932479283747", 729)]
        [TestCase("93957753888", 512)]
        public void ItReturnsCorrectValue(string series, int expectedResult)
        {
            var result = _largestProductInSeries.Execute(series);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
