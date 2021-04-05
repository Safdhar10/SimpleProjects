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
using System.Web;
using System.Security;

namespace Password_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RandomGenerator RG = new RandomGenerator();
        public MainWindow()
        {
            InitializeComponent();
            LetterText.Text = "3";
            RG.RandomPasswordGenerator(10, 3, 4, 2, 1);
        }

        private void UPCheck(object sender, RoutedEventArgs e)
        {
            if(UpCheckButton.IsChecked==true)
            {
                UPText.IsEnabled = true;
            }
            else
            {
                UPText.Text = "0";
                Total();
                UPText.IsEnabled = false;
            }
        }

        private void SYMCheck(object sender, RoutedEventArgs e)
        {
            if(SymButton.IsChecked==true)
            {
                SymText.IsEnabled = true;
            }
            else
            {
                SymText.Text = "0";
                Total();
                SymText.IsEnabled = false;
            }
        }

        private void NUMCheck(object sender, RoutedEventArgs e)
        {
            if (NumCheckButton.IsChecked == true)
            {
                NumText.IsEnabled = true;
            }
            else
            {
                NumText.Text = "0";
                Total();
                NumText.IsEnabled = false;
            }
        }

        private bool IsValid(int num)
        {

            if (num >= 0 && num <= 256)
            {
                return true;
            }
            else
                return false;
        }


        private void LetterText_TextChanged(object sender, TextChangedEventArgs e)
        {
            TotalLength.Text = (Convert.ToInt32(LetterText.Text)).ToString();
        }
        private void UPText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (UpCheckButton.IsChecked == true)
                //TotalLength.Text = (Convert.ToInt32(LetterText.Text)+Convert.ToInt32(UPText.Text)).ToString();
                Total();
            }

        private void NumText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NumCheckButton.IsChecked == true)
                //TotalLength.Text = (Convert.ToInt32(LetterText.Text) + Convert.ToInt32(NumText.Text) + Convert.ToInt32(UPText.Text)).ToString();
                Total();
        }

        private void SymText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SymButton.IsChecked == true)
                //TotalLength.Text = (Convert.ToInt32(LetterText.Text) + Convert.ToInt32(NumText.Text) + Convert.ToInt32(SymText.Text) + Convert.ToInt32(UPText.Text)).ToString();
                Total();
        }
        private void Total()
        {
            TotalLength.Text = (Convert.ToInt32(LetterText.Text) + Convert.ToInt32(NumText.Text) + Convert.ToInt32(SymText.Text) + Convert.ToInt32(UPText.Text)).ToString();
        }

        private void GeneratePass(object sender, RoutedEventArgs e)
        {
            string _getPassword=RG.RandomPasswordGenerator(Convert.ToInt32(TotalLength.Text), Convert.ToInt32(NumText.Text), Convert.ToInt32(LetterText.Text), Convert.ToInt32(UPText.Text), Convert.ToInt32(SymText.Text));
            Result.Text = _getPassword;
        }
        private void TotalLength_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!IsValid(Convert.ToInt32(TotalLength.Text)))
                MessageBox.Show("Please Enter Password Length Between 256 Characters");
            
        }

        private void CopyToClip(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Result.Text);

        }
    }
}
