using NUnit.Framework;

namespace GetPrimeFactors
{
    [TestFixture]
    public class CalculatePrimeFactorsTest
    {
        [Test]
        public void IsAnyPrimeNumbersGenerated()
        {
            var primeFactors = new CalculatePrimeFactors();

            int number = 90;

            primeFactors.Calculate(number);

            Assert.IsTrue(primeFactors.PrimeNumbers.Count > 0);
        }
    }
}
