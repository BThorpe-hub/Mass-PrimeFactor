namespace Mass_PrimeFactor.Models.Selector
{
    internal interface IAlgorthimSelector
    {
        public IEnumerable<string> GetNames();
        public IPrimeFactorAlgorithm GetSelected();
        public void SetIndex(int index);
        public int GetIndex();

    }
}
