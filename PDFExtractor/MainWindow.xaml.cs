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

namespace PDFExtractor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private const string app_name = "PDF Miner v1.0";

        public MainWindow()
        {
            InitializeComponent();
            this.Title = app_name;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void statusBar_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
