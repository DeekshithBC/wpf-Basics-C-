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

namespace Image_Control
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

        private void myImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri(@"/https://www.royalenfield.com/content/dam/royal-enfield/united-kingdom/motorcycles/continental-gt/colours/studio-shots/new/rocker-red/front-view.png", UriKind.Relative));
        }
    }
}
