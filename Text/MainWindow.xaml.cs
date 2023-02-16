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

namespace Text
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock myTb = new TextBlock();
            myTb.Text = "helloow World";
            myTb.Inlines.Add("This is added using Inlines");
            myTb.Inlines.Add(new Run("Run text that i added in code behind")

            {
                Foreground = Brushes.Red,
            TextDecorations = TextDecorations.Underline
                });
            myTb.TextWrapping = TextWrapping.Wrap;
            myTb.Foreground = Brushes.Black;
            this.Content= myTb; ;

            }
    }
}
