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

namespace Radio_Buttons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rbObama_Checked(object sender, RoutedEventArgs e)
        {
            lbobama.Foreground = Brushes.Aquamarine;
        }

        private void rbObama_Unchecked(object sender, RoutedEventArgs e)
        {
            lbobama.Foreground = Brushes.Brown ;

        }

        private void rdTrump_Checked(object sender, RoutedEventArgs e)
        {
            lbtrump.Foreground = Brushes.Aquamarine;
        }

        private void rdTrump_Unchecked(object sender, RoutedEventArgs e)
        {
            lbtrump.Foreground = Brushes.Brown;
        }

        private void rbMccain_Checked(object sender, RoutedEventArgs e)
        {
          lbmccain .Foreground = Brushes.Aquamarine;
        }

        private void rbMccain_Unchecked(object sender, RoutedEventArgs e)
        {
            lbmccain.Foreground = Brushes.Brown;
        }

        private void rbBiden_Checked(object sender, RoutedEventArgs e)
        {
           lbbiden .Foreground = Brushes.Aquamarine;
        }

        private void rbBiden_Unchecked(object sender, RoutedEventArgs e)
        {
           lbbiden.Foreground = Brushes.Brown;
        }
    }
}
