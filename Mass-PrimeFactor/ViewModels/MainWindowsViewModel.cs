using Mass_PrimeFactor.Models;
using Mass_PrimeFactor.Models.Selector;
using System.ComponentModel;

namespace Mass_PrimeFactor.ViewModels
{
    internal class MainWindowsViewModel(IInputModel inputModel, IAlgorthimSelector algorthimSelector) : IMainWindowsViewModel, INotifyPropertyChanged
    {
        private readonly IInputModel _inputModel = inputModel;
        private readonly IAlgorthimSelector _algorthimSelector = algorthimSelector;
    
        public event PropertyChangedEventHandler PropertyChanged;

        public string UserInput
        {
            get { return _inputModel.GetNumberAsString(); }
            set
            {
                _inputModel.SetNumber(value);
                OnPropertyChanged(nameof(PrimeFactors));
            }
        }

        public string PrimeFactors
        {
            get
            {
                return _algorthimSelector.GetSelected().Calculate(_inputModel.GetNumber());
            }
            set
            {
                OnPropertyChanged(nameof(PrimeFactors));
            }
        }

        public IEnumerable<string> PrimeFactorAlgorithmsNames
        {
            get { return _algorthimSelector.GetNames(); }
            set { }
        }

        public int SelectedAlgorithm
        {
            get { return _algorthimSelector.GetIndex(); }
            set
            {
                _algorthimSelector.SetIndex(value);
                OnPropertyChanged(nameof(PrimeFactors));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
