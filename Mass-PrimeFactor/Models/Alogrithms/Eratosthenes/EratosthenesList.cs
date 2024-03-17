using System.Collections;

namespace Mass_PrimeFactor.Models.Alogrithm
{
    internal class EratosthenesList : IEratosthenesList 
    {
        private readonly List<int> _primeNumbers;
        private int _lastChecked = 2;

        public EratosthenesList()
        {
            _primeNumbers = [2];
            _lastChecked = 2;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int prime in _primeNumbers)
            {
                yield return prime;
            }

            while (_lastChecked < int.MaxValue)
            {
                _lastChecked++;

                if (IsPrime(_lastChecked))
                {
                    _primeNumbers.Add(_lastChecked);
                    yield return _lastChecked;
                }
            }
        }
  
        private bool IsPrime(int checkValue)
        {
            bool isPrime = true;

            foreach (int prime in _primeNumbers)
            {
                if ((checkValue % prime) == 0 && prime <= Math.Sqrt(checkValue))
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
