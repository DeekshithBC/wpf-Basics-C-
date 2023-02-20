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

namespace CheckBox
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
        private void cbparentCheckedchaneged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbparent.IsChecked == true);
            cbveg.IsChecked = newVal;
            cbvegnonveg.IsChecked=newVal;
            cbnonveg.IsChecked = newVal;
        }
        private void cbfoodcheckedchanged(object sender, RoutedEventArgs e)
        {
            cbparent.IsChecked = null;
            if( (cbveg.IsChecked == true) && (cbnonveg.IsChecked == true) && (cbvegnonveg.IsChecked == true))
                    {
                cbparent.IsChecked = true;

                    }
            if ((cbveg.IsChecked == false) && (cbnonveg.IsChecked == false) && (cbvegnonveg.IsChecked == false))
            {
                cbparent.IsChecked = false;
            }
                    }
    }
}
