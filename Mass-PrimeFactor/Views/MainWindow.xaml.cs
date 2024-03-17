using Mass_PrimeFactor.Models;
using Mass_PrimeFactor.ViewModels;
using System.Windows;
using System.Windows.Controls;
using Unity;

namespace Mass_PrimeFactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var mainWindowsViewModel = ((App)Application.Current).Container.Resolve<IMainWindowsViewModel>();

            // Add the ViewModel instance to the resources
            Resources.Add("mainWindowsViewModel", mainWindowsViewModel);

            // Set the DataContext of the window to the ViewModel
            DataContext = mainWindowsViewModel;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string selectedItem = comboBox.SelectedItem as string;
                // Do something with the selected item
                MessageBox.Show($"Selected Item: {selectedItem}");
            }
        }


    }
}