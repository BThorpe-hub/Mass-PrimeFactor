using Mass_PrimeFactor.Models;
using Mass_PrimeFactor.Models.Alogrithm;
using Moq;
using PrimeFactorTest.MockData;

namespace PrimeFactorTest.Models
{
    public class EratosthenesShould
    {
        [Theory]
        [InlineData(1, "")]
        [InlineData(13, "13")]
        [InlineData(27, "3")]
        [InlineData(234, "2, 3, 13")]
        [InlineData(23.4, "")]
        public static void Calculate(double number, string expected)
        {
            var mockEratosthenesList = new Mock<IEratosthenesList>();
            mockEratosthenesList.Setup(s => s.GetEnumerator())
                .Returns(MockPrimeNumbers.GetMockData().GetEnumerator());

            var model = new Eratosthenes(mockEratosthenesList.Object);

            var result = model.Calculate(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void GetName()
        {
            var mockEratosthenesList = new Mock<IEratosthenesList>();
            var model = new Eratosthenes(mockEratosthenesList.Object);

            var result = model.GetName();

            Assert.Equal("Eratosthenes", result);
        }

        [Theory]
        [InlineData("1, 2, 3", new int[] { 1, 2, 3 })]
        [InlineData("1, 2, 3", new int[] { 1, 2, 2, 3 })]
        [InlineData("1", new int[] { 1 })]
        [InlineData("", new int[] { })]
        public static void FactorsToString(string expected, IEnumerable<int> factors)
        {
            var result = Eratosthenes.FactorsToString(factors);
            Assert.Equal(expected, result);
        }
    }
}
