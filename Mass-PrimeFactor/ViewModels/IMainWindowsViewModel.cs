using Mass_PrimeFactor.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

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
