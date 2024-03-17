using Mass_PrimeFactor.Models.Alogrithm;

namespace Mass_PrimeFactor.Models
{
    public class Eratosthenes(IEratosthenesList primeNumbers) : IPrimeFactorAlgorithm
    {
        private const string _name = "Eratosthenes";
        private readonly IEratosthenesList _primeNumbers = primeNumbers;

        public string Calculate(double number)
        {
            if (number == 0)
                return "Please Enter a Valid Number";

            List<int> factors = new List<int>();

            foreach (int prime in _primeNumbers)
            {
                while (number % prime == 0)
                {
                    number /= prime;
                    factors.Add(prime);
                }

                if (number == 1)
                {
                    break;
                }
            }
            return FactorsToString(factors);
        }

        public string GetName()
        {
            return _name;
        }

        public static string FactorsToString(IEnumerable<int> factors)
        {
            var distinct = factors.Distinct();
            return string.Join(", ", distinct);
        }
    }
}
