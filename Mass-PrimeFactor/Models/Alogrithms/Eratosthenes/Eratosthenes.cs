using Mass_PrimeFactor.Models.Alogrithm;
using System.ComponentModel;

namespace Mass_PrimeFactor.Models
{
    internal class Eratosthenes : IPrimeFactorAlgorithm
    {
        private const string _name = "Eratosthenes";
        private readonly IEratosthenesList _primeNumbers;

        public Eratosthenes(IEratosthenesList primeNumbers)
        {
            _primeNumbers = primeNumbers;
        }

        public string Calculate(double number)
        {
            if (number == 0)
                return "Please Enter a Valid Number";

            List<int> factors = new List<int>();
            factors.Add(1);

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

        private string FactorsToString(IEnumerable<int> factors)
        {
            var distinct = factors.Distinct();
            return string.Join(", ", distinct);
        }
    }
}
