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

namespace BMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> HeightDetails = new List<string>();
        string[] WeightDetails = new string[] { "kg", "pound" };
        public MainWindow()
        {
            InitializeComponent();
            AddDetails();

        }
        private void AddDetails()
        {
            HeightDetails.Add("cm");
            HeightDetails.Add("m");
            HeightDetails.Add("ft");
            HeightDetails.Add("in");
            HeightDetails.Add("yd");
            Height.ItemsSource = HeightDetails;
            Weight.ItemsSource = WeightDetails;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HeightWeightConverter HT = new HeightWeightConverter();
            double _height = Convert.ToDouble(TextHeight.Text);
            if(!Height.SelectedItem.Equals("m"))
            {
                _height = HT.HeightConverter(Height.Text, _height);
            }
            double _weight = Convert.ToDouble(TextWeight.Text);
            if(!Weight.SelectedItem.Equals("kg"))
            {
                _weight = HT.WeightConverter(_weight);
            }
            double _bmiResult =Math.Round((_weight / (_height * _height)),2);
            MessageBox.Show("Your Bmi is :" + _bmiResult.ToString());
        }
    }
}
