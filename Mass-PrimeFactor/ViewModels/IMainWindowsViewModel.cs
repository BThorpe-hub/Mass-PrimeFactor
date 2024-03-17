using System.ComponentModel;

namespace Mass_PrimeFactor.ViewModels
{
    public interface IMainWindowsViewModel : INotifyPropertyChanged
    {
        public string UserInput
        {
            get;set;
        }

        public string PrimeFactors
        {
            get;set;
        }

        public IEnumerable<string> PrimeFactorAlgorithmsNames
        {
            get; set;
        }

        public int SelectedAlgorithm
       {
            get; set;
        }
    }
}
