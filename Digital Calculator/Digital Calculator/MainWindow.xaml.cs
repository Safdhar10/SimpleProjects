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

namespace Digital_Calculator
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

        private void WriteContent(string input)
        {
            DisplayBlock.Text += input;
        }
        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteContent(ZeroBtn.Content.ToString());
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteContent(OneBtn.Content.ToString());
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteContent(TwoBtn.Content.ToString());
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteContent(ThreeBtn.Content.ToString());
        }

        private void XSquareBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void fourBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteContent(fourBtn.Content.ToString());
        }

        private void fiveBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteContent(fiveBtn.Content.ToString());
        }

        private void sixBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteContent(sixBtn.Content.ToString());
        }

        private void xfactorBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sevenBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteContent(sevenBtn.Content.ToString());
        }

        private void eightBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteContent(eightBtn.Content.ToString());
        }

        private void nineBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteContent(nineBtn.Content.ToString());
        }

        private void TextBlock_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool check=
            e.Handled = 
        }
    }
}
