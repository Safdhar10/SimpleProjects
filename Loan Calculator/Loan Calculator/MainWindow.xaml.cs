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

namespace Loan_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculate CA = new Calculate();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoanText_LostFocus(object sender, RoutedEventArgs e)
        {
            string _get = LoanText.Text;
            LoanText.Text = CA.ConvertCurrencyFormat(_get).ToString("C");
        }

        private string ConvertMoneyintoDouble(string _loanAmount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < _loanAmount.Length; i++)
            {
                if (char.IsDigit(_loanAmount[i]))
                {
                    sb.Append(_loanAmount[i]);
                }
                else if (_loanAmount[i] == '.')
                {
                    sb.Append(_loanAmount[i]);
                }
            }
            return sb.ToString();
        }

        private void CalculateEMI_Click(object sender, RoutedEventArgs e)
        {
            string _loanAmount = LoanText.Text;
            double _principal = double.Parse(ConvertMoneyintoDouble(_loanAmount));
            double _rate = double.Parse(RateText.Text);
            int _n = int.Parse(TenureText.Text);
            if (YR.IsChecked == true)
            {
                _n = _n * 12;
            }
            double _emi=CA.CalculateEmi(_principal, _rate, _n);
            double _totalPay = _emi * _n;
            double _totalIntrest = _totalPay - _principal;
            TotalEmi.Content = _emi.ToString("c2");
            TotalInterest.Content = _totalIntrest.ToString("c2");
            TotaPAy.Content = _totalPay.ToString("c2");
            ResultPanel2.Visibility = Visibility.Hidden;
            ResultPanel3.Visibility = Visibility.Hidden;
            ResultPanel4.Visibility = Visibility.Hidden;
            ResultPanel1.Visibility = Visibility.Visible;
        }

        private void MO_Click(object sender, RoutedEventArgs e)
        {
            YR.IsChecked = false;
        }

        private void YR_Click(object sender, RoutedEventArgs e)
        {
            MO.IsChecked = false;
        }

        BrushConverter bc = new BrushConverter();
        private void EMIBtn_Click(object sender, RoutedEventArgs e)
        {
            LoanBtn.Background = (Brush)bc.ConvertFrom("#536162");
            TenureBtn.Background = (Brush)bc.ConvertFrom("#536162");
            InterestBtn.Background = (Brush)bc.ConvertFrom("#536162");
            EMIBtn.Background = new SolidColorBrush(Colors.White);
            LoanPanel.Visibility = Visibility.Hidden;
            TenurePanel.Visibility = Visibility.Hidden;
            RatePanel.Visibility = Visibility.Hidden;
            EmiPanel.Visibility = Visibility.Visible;
        }

        private void LoanBtn_Click(object sender, RoutedEventArgs e)
        {
            EMIBtn.Background = (Brush)bc.ConvertFrom("#536162");
            TenureBtn.Background = (Brush)bc.ConvertFrom("#536162");
            InterestBtn.Background = (Brush)bc.ConvertFrom("#536162");
            LoanBtn.Background = new SolidColorBrush(Colors.White);
            LoanPanel.Visibility = Visibility.Visible;
            TenurePanel.Visibility = Visibility.Hidden;
            RatePanel.Visibility = Visibility.Hidden;
            EmiPanel.Visibility = Visibility.Hidden;
        }

        private void TenureBtn_Click(object sender, RoutedEventArgs e)
        {
            LoanBtn.Background = (Brush)bc.ConvertFrom("#536162");
            EMIBtn.Background = (Brush)bc.ConvertFrom("#536162");
            InterestBtn.Background = (Brush)bc.ConvertFrom("#536162");
            TenureBtn.Background = new SolidColorBrush(Colors.White);
            LoanPanel.Visibility = Visibility.Hidden;
            TenurePanel.Visibility = Visibility.Visible;
            RatePanel.Visibility = Visibility.Hidden;
            EmiPanel.Visibility = Visibility.Hidden;
        }

        private void InterestBtn_Click(object sender, RoutedEventArgs e)
        {
            LoanBtn.Background = (Brush)bc.ConvertFrom("#536162");
            TenureBtn.Background = (Brush)bc.ConvertFrom("#536162");
            EMIBtn.Background = (Brush)bc.ConvertFrom("#536162");
            InterestBtn.Background = new SolidColorBrush(Colors.White);
            LoanPanel.Visibility = Visibility.Hidden;
            TenurePanel.Visibility = Visibility.Hidden;
            RatePanel.Visibility = Visibility.Visible;
            EmiPanel.Visibility = Visibility.Hidden;
        }

        private void CalculateLoan_Click(object sender, RoutedEventArgs e)
        {
            string _emiAmount = EmiText.Text;
            double _emi = double.Parse(ConvertMoneyintoDouble(_emiAmount));
            double _rate = double.Parse(RateText2.Text);
            int _n = int.Parse(TenureText2.Text);
            if (YR1.IsChecked == true)
            {
                _n = _n * 12;
            }
            int _principal =(int) CA.CalculateLoan(_emi, _rate, _n);
            TotalPrincipal.Content = _principal.ToString();
            double _totalPayment = _emi * _n;
            double _totalIntrest = _totalPayment - _principal;
            TotalInterest2.Content = _totalIntrest;
            TotaPAy2.Content = _totalPayment;
            ResultPanel2.Visibility = Visibility.Visible;
            ResultPanel3.Visibility = Visibility.Hidden;
            ResultPanel4.Visibility = Visibility.Hidden;
            ResultPanel1.Visibility = Visibility.Hidden;
        }

        private void EmiText_LostFocus(object sender, RoutedEventArgs e)
        {
            string _get = EmiText.Text;
            EmiText.Text = CA.ConvertCurrencyFormat(_get).ToString("C");
        }

        private void CalculateTenure_Click(object sender, RoutedEventArgs e)
        {
            string _emiAmount = EmiText3.Text;
            double _emi = double.Parse(ConvertMoneyintoDouble(_emiAmount));
            string _loanAmount = LoanText3.Text;
            double _loan = double.Parse(ConvertMoneyintoDouble(_loanAmount));
            double _rate = double.Parse(RateText3.Text);
            double _month =Math.Ceiling( CA.CalculateTenure(_loan, _rate, _emi));
            if(_month<=12)
            {
                LoanTenure.Content = _month.ToString() + "Months";
            }
            else
            {

                LoanTenure.Content = ((int)_month/12).ToString() + " Years " + (_month%12).ToString() + " Months";
            }
            TotaPAy3.Content = (_emi * _month).ToString("C");
            TotalInterest3.Content = ((_emi * _month) - _loan).ToString("C");
            ResultPanel2.Visibility = Visibility.Hidden;
            ResultPanel3.Visibility = Visibility.Visible;
            ResultPanel4.Visibility = Visibility.Hidden;
            ResultPanel1.Visibility = Visibility.Hidden;
        }

        private void LoanText3_LostFocus(object sender, RoutedEventArgs e)
        {

            string _get = LoanText3.Text;
            LoanText3.Text = CA.ConvertCurrencyFormat(_get).ToString("C");
        }

        private void EmiText3_LostFocus(object sender, RoutedEventArgs e)
        {

            string _get = EmiText3.Text;
            EmiText3.Text = CA.ConvertCurrencyFormat(_get).ToString("C");
        }

        private void CalculateInterest_Click(object sender, RoutedEventArgs e)
        {
            string _loanAmount = LoanText4.Text;
            string _emiAmount = EmiText4.Text;
            double _loan = double.Parse(ConvertMoneyintoDouble(_loanAmount));
            double _emi = double.Parse(ConvertMoneyintoDouble(_emiAmount));
            int _n = int.Parse(Tenure2.Text);
            if (YR2.IsChecked == true)
            {
                _n = _n * 12;
            }
            double _intrest = CA.CalculateInterest(_loan, _emi, _n);

            ResultPanel2.Visibility = Visibility.Hidden;
            ResultPanel3.Visibility = Visibility.Hidden;
            ResultPanel4.Visibility = Visibility.Visible;
            ResultPanel1.Visibility = Visibility.Hidden;
        }

        private void EmiText4_LostFocus(object sender, RoutedEventArgs e)
        {
            string _get = EmiText4.Text;
            EmiText4.Text = CA.ConvertCurrencyFormat(_get).ToString("C");
        }

        private void LoanText4_LostFocus(object sender, RoutedEventArgs e)
        {

            string _get = LoanText4.Text;
            LoanText4.Text = CA.ConvertCurrencyFormat(_get).ToString("C");
        }
    }
}
