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
using System.Net;
using Newtonsoft.Json;

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
            //StreamReader setin = new StreamReader(@"E:\SimpleProjects\CurrencyConverter\CurrencyConverter\CurrencyDetails.txt");
            //int count = File.ReadLines(@"E:\SimpleProjects\CurrencyConverter\CurrencyConverter\CurrencyDetails.txt").Count();
            //while(count-->0)
            //{
            //    string[] _getLine = setin.ReadLine().Split(':');
            //    string _currencyAbbrevation = _getLine[0];
            //    string _currencyFullName = _getLine[1];
            //    double _currencyRate = Convert.ToDouble(_getLine[2]);
            //    CurrencyNameAndValue.Add(new CurrencyDetail { CurrencyAbbrevation = _currencyAbbrevation, CurrencyFullForm = _currencyFullName, CurrencyRate = _currencyRate });
            //}
            callWebServices();
            FromConverter.ItemsSource = CurrencyNameAndValue;
            ToConverter.ItemsSource = CurrencyNameAndValue;
            FromConverter.SelectedIndex=60;
            ToConverter.SelectedIndex = 0;
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            var _dataFrom = FromConverter.SelectedItem as CurrencyDetail;
            var _dataTo = ToConverter.SelectedItem as CurrencyDetail;
            if(AmountConverter.Text=="")
            {
                AmountConverter.Focus();
                MessageBox.Show("Enter Amount to Convert");
            }
            else if(FromConverter.SelectedItem==ToConverter.SelectedItem)
            {
                MessageBox.Show("You are Selected Same From Currency and To Currency....");
            }
            else
            {
                double _enteredAmount =Convert.ToDouble( AmountConverter.Text);
                double _fromCurrencyRate = Convert.ToDouble(_dataFrom.CurrencyRate);
                double _toCurrencyRate = Convert.ToDouble(_dataTo.CurrencyRate);
                double _convertedCurrency =Math.Round( ((_enteredAmount * _toCurrencyRate) / _fromCurrencyRate),3);
                //MessageBox.Show(string.Format("{0:0.00}",_convertedCurrency));
                BeforeConvertedCurrency.Content =  _enteredAmount.ToString() + " " + _dataFrom.CurrencyAbbrevation;
                t1.Visibility=Visibility.Visible;
                AfterConvertedCurrency.Content =  _convertedCurrency.ToString() + " " + _dataTo.CurrencyAbbrevation;
                FromConvert.Content = "1 " + _dataFrom.CurrencyAbbrevation;
                double _oneConverCurrency = Math.Round((_toCurrencyRate/_fromCurrencyRate),3); 
                t2.Visibility = Visibility.Visible;
                ToConvert.Content = _oneConverCurrency.ToString()+" "+_dataTo.CurrencyAbbrevation;
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
        private void callWebServices()
        {
            var getData = webGetMethod("https://api.fastforex.io/fetch-all?api_key=191df415b7-f9a2494e96-qqxhve");
            var obj = JsonConvert.DeserializeObject<Currency>(getData);
            foreach (var result in obj.results)
            {
                CurrencyNameAndValue.Add(new CurrencyDetail { CurrencyAbbrevation = result.Key, CurrencyRate = result.Value }); 
            }
           

        }
        public string webGetMethod(string URL)
        {
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;
        }
    }
}
