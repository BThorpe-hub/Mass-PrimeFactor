namespace Mass_PrimeFactor.Models.Selector
{
    internal class AlgorthimSelector : IAlgorthimSelector
    {
        private IPrimeFactorAlgorithm[] _algorithmList;
        private int _index;

        public AlgorthimSelector(IPrimeFactorAlgorithm[] algorithms)
        {
            _algorithmList = algorithms;
            _index = 0;
        }

        public IEnumerable<string> GetNames()
        {
            return _algorithmList.Select(a => a.GetName());
        }

        public IPrimeFactorAlgorithm GetSelected()
        {
            return _algorithmList[_index];
        }

        public void SetIndex(int index)
        {
            _index = index;
        }

        public int GetIndex()
        {
            return _index;
        }
    }
}
