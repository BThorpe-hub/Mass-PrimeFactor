namespace Mass_PrimeFactor.Models.Alogrithm
{
    internal interface IEratosthenesList : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator();     
    }
}
