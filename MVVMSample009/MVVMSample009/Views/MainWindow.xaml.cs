using MVVMSample009.ViewModels;
using System.Windows;

namespace MVVMSample009.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
