using CourseWorkWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWorkWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }

        private void StopBtnClick(object sender, RoutedEventArgs e)
        {
            viewModel.Stop();
        }

        private void StartBtnCLick(object sender, RoutedEventArgs e)
        {
            viewModel.Start();
        }
    }
}
