using MVVM_pr7.Model;
using MVVM_pr7.View;
using MVVM_pr7.ViewModel;
using System.Windows;

namespace MVVM_pr7
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new SmokeViewModel(new FromApp(), new DerSer());
        }
    }
    
}

