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
using System.IO;

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<CurrencyDetail> CurrencyNameAndValue = new List<CurrencyDetail>();
        

        public MainWindow()
        {
            InitializeComponent();
            StreamReader setin = new StreamReader(@"E:\SimpleProjects\CurrencyConverter\CurrencyConverter\CurrencyDetails.txt");
            int count = File.ReadLines(@"E:\SimpleProjects\CurrencyConverter\CurrencyConverter\CurrencyDetails.txt").Count();
            while(count-->0)
            {
                string[] _getLine = setin.ReadLine().Split(':');
                string _currencyAbbrevation = _getLine[0];
                string _currencyFullName = _getLine[1];
                double _currencyRate = Convert.ToDouble(_getLine[2]);
                CurrencyNameAndValue.Add(new CurrencyDetail { CurrencyAbbrevation = _currencyAbbrevation, CurrencyFullForm = _currencyFullName, CurrencyRate = _currencyRate });
            }
            FromConverter.ItemsSource = CurrencyNameAndValue;
            ToConverter.ItemsSource = CurrencyNameAndValue;
            FromConverter.SelectedIndex=23;
            ToConverter.SelectedIndex = 0;
        }
        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            var _dataFrom = FromConverter.SelectedItem as CurrencyDetail;
            var _dataTo = ToConverter.SelectedItem as CurrencyDetail;
            if(AmountConverter.Text=="")
            {
                AmountConverter.Focus();
            }
            else
            {
                double _enteredAmount =Convert.ToDouble( AmountConverter.Text);
                double _fromCurrencyRate = Convert.ToDouble(_dataFrom.CurrencyRate);
                double _toCurrencyRate = Convert.ToDouble(_dataTo.CurrencyRate);
                double _convertedCurrency = (_enteredAmount * _toCurrencyRate) / _fromCurrencyRate;
                MessageBox.Show(_convertedCurrency.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AmountConverter.Clear();
            FromConverter.SelectedIndex = 23;
            ToConverter.SelectedIndex = 0;
        }

        private void FromConverter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ToConverter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
