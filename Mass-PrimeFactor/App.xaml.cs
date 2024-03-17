using Mass_PrimeFactor.Models;
using Mass_PrimeFactor.Models.Alogrithm;
using Mass_PrimeFactor.Models.Alogrithms;
using Mass_PrimeFactor.Models.Selector;
using Mass_PrimeFactor.ViewModels;
using System.Windows;
using Unity;

namespace Mass_PrimeFactor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IUnityContainer Container { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Container = new UnityContainer();
            Container.RegisterType<IEratosthenesList, EratosthenesList>();
            Container.RegisterType<IPrimeFactorAlgorithm, Eratosthenes>("Eratosthenes");
            Container.RegisterType<IPrimeFactorAlgorithm, TestAlgorithm>("TestAlgorithm");
            Container.RegisterType<IAlgorthimSelector, AlgorthimSelector>();
            Container.RegisterType<IInputModel, InputModel>();
            Container.RegisterType<IMainWindowsViewModel, MainWindowsViewModel>();
        }
    }

}
