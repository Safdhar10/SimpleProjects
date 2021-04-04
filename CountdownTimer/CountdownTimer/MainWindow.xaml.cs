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

namespace CountdownTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            frame.Navigate(new Uri("CountdownPage.xaml", UriKind.Relative));
        }

       

        private void Stopwatch(object sender, RoutedEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            TimerButton.Background = new SolidColorBrush(Colors.Bisque);
            StopWatchButton.Background = (Brush)bc.ConvertFrom("#caf7e3");

        }

        private void Timer(object sender, RoutedEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            StopWatchButton.Background = new SolidColorBrush(Colors.Bisque);
            TimerButton.Background = (Brush)bc.ConvertFrom("#caf7e3");
        }
    }
}
